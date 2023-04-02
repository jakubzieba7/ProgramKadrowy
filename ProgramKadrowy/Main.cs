using ProgramKadrowy.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramKadrowy
{
    public partial class Main : Form
    {
        private JSONSerializers<List<Employee>> _serializers = new JSONSerializers<List<Employee>>();

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            //NewtonSoftJSONTest();
            FillSortListIsActiveCB();
            RefreshGrid();
            SetColumnsHeaders();

            if (IsMaximize)
                WindowState = FormWindowState.Maximized;
        }

        private void SetColumnsHeaders()
        {
            dgvEmployeesGrid.Columns[nameof(Employee.EmployeeId)].HeaderText = "L.p.";
            dgvEmployeesGrid.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
            dgvEmployeesGrid.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dgvEmployeesGrid.Columns[nameof(Employee.Contract)].HeaderText = "Umowa";
            dgvEmployeesGrid.Columns[nameof(Employee.Remarks)].HeaderText = "Uwagi";
            dgvEmployeesGrid.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
            dgvEmployeesGrid.Columns[nameof(Employee.EmploymentDate)].HeaderText = "Data zatrudnienia";
            dgvEmployeesGrid.Columns[nameof(Employee.UnemploymentDate)].HeaderText = "Data zakończenia współpracy";
            dgvEmployeesGrid.Columns[nameof(Employee.IsActive)].HeaderText = "Aktualnie zatrudniony";
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

            List<Employee> employees1 = _serializers.DeserializeFromFile_NewtonSoft().ToList();

            dgvEmployeesGrid.DataSource = employees1;
        }

        private void RefreshGrid()
        {
            dgvEmployeesGrid.DataSource = _serializers.DeserializeFromFile_NewJson().OrderBy(x => x.EmployeeId).Select(x => new Employee() { EmployeeId = x.EmployeeId, FirstName = x.FirstName, LastName = x.LastName, Contract = x.Contract, Remarks = x.Remarks, Salary = x.Salary, EmploymentDate = x.EmploymentDate, UnemploymentDate = x.IsActive ? null : x.UnemploymentDate, IsActive = x.IsActive }).ToList();
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
            List<Employee> employees = _serializers.DeserializeFromFile_NewJson().OrderBy(x => x.EmployeeId).Select(x => new Employee() { EmployeeId = x.EmployeeId, FirstName = x.FirstName, LastName = x.LastName, Contract = x.Contract, Remarks = x.Remarks, Salary = x.Salary, EmploymentDate = x.EmploymentDate, UnemploymentDate = x.IsActive ? null : x.UnemploymentDate, IsActive = x.IsActive }).ToList();
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

        private void UnemploymentDateVisibility()
        {
            List<Employee> newEmployeeList = new List<Employee>();

            foreach (DataGridViewRow row in dgvEmployeesGrid.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeId = Convert.ToInt32(row.Cells[nameof(employee.EmployeeId)].Value),
                    FirstName = row.Cells[nameof(employee.FirstName)].Value.ToString(),
                    LastName = row.Cells[nameof(employee.LastName)].Value.ToString(),
                    Contract = row.Cells[nameof(employee.Contract)].Value.ToString(),
                    Remarks = row.Cells[nameof(employee.Remarks)].Value.ToString(),
                    Salary = Convert.ToDecimal(row.Cells[nameof(employee.Salary)].Value),
                    EmploymentDate = (DateTime)row.Cells[nameof(employee.EmploymentDate)].Value,
                    UnemploymentDate = (DateTime)row.Cells[nameof(employee.UnemploymentDate)].Value,
                    IsActive = (bool)row.Cells[nameof(employee.IsActive)].Value
                };

                if (employee.IsActive)
                    employee.UnemploymentDate = null;

                newEmployeeList.Add(employee);
            }

            dgvEmployeesGrid.DataSource = newEmployeeList;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();
        }
    }
}
