using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProgramKadrowy
{
    public partial class Main : Form
    {
        private JSONSerializers<List<Employee>> _serializers = new JSONSerializers<List<Employee>>();
        
        public Main()
        {
            InitializeComponent();

            //NewtonSoftJSONTest();

            FillSortListIsActiveCB();

            RefreshGrid();

            SetColumnsHeaders();
            
        }

        private void SetColumnsHeaders()
        {
            dgvEmployeesGrid.Columns[0].HeaderText = "L.p.";
            dgvEmployeesGrid.Columns[1].HeaderText = "Imię";
            dgvEmployeesGrid.Columns[2].HeaderText = "Nazwisko";
            dgvEmployeesGrid.Columns[3].HeaderText = "Umowa";
            dgvEmployeesGrid.Columns[4].HeaderText = "Uwagi";
            dgvEmployeesGrid.Columns[5].HeaderText = "Wynagrodzenie";
            dgvEmployeesGrid.Columns[6].HeaderText = "Data zatrudnienia";
            dgvEmployeesGrid.Columns[7].HeaderText = "Data zakończenia współpracy";
            dgvEmployeesGrid.Columns[8].HeaderText = "Aktualnie zatrudniony";
        }

        public void NewtonSoftJSONTest()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId= 1,
                    FirstName = "Jan",
                    LastName="Zięba",
                    Remarks="Test",
                    Salary=1000,
                    EmploymentDate= DateTime.Now,
                    UnemploymentDate= DateTime.Now,
                    IsActive=true,
                },
                new Employee()
                {
                    EmployeeId= 2,
                    FirstName="Zofia",
                    LastName="Zięba",
                    Remarks="Test",
                    Salary=1000,
                    EmploymentDate= DateTime.Now,
                    UnemploymentDate= DateTime.Now,
                    IsActive=false,
                }
            };

            _serializers.SerializeToFile_NewtonSoft(employees);

            List<Employee> employees1= _serializers.DeserializeFromFile_NewtonSoft().ToList();

            dgvEmployeesGrid.DataSource = employees1;
        }

        private void RefreshGrid()
        {
            dgvEmployeesGrid.DataSource = _serializers.DeserializeFromFile_NewJson().OrderBy(x => x.EmployeeId).ToList();
            cbSortListIsActive.SelectedItem = "Wszyscy";
        }


        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            RefreshGrid();
        }

        private void btEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployeesGrid.SelectedRows == null)
            {
                MessageBox.Show("Zaznacz pracownika do edycji");
                return;
            }

            AddEmployee addEmployee = new AddEmployee(Convert.ToInt32(dgvEmployeesGrid.SelectedRows[0].Cells[0].Value));
            addEmployee.ShowDialog();
            RefreshGrid();
        }

        private void btRefreshGridView_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void FillSortListIsActiveCB()
        {
            cbSortListIsActive.Items.Add("Wszyscy");
            cbSortListIsActive.Items.Add("W zatrudnieniu");
            cbSortListIsActive.Items.Add("Poza zatrudnieniem");
            Refresh();
        }

        private void cbSortListIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> employees = _serializers.DeserializeFromFile_NewJson().OrderBy(x=>x.EmployeeId).ToList();
            List<Employee> filteredEmployees;
           
            switch (cbSortListIsActive.SelectedItem)
            {
                case "Poza zatrudnieniem":
                    filteredEmployees = employees.Where(x => x.IsActive is false).ToList();
                    break;
                case "W zatrudnieniu":
                    filteredEmployees = employees.Where(x => x.IsActive is true).ToList();
                    break;
                default:
                    filteredEmployees = employees.ToList();
                    break;
            }
            
            dgvEmployeesGrid.DataSource = filteredEmployees;
        }
    }
}
