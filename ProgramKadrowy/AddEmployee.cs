using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKadrowy
{
    public partial class AddEmployee : Form
    {
        private JSONSerializers _serializer = new JSONSerializers();
        private int _employeeID;
        public AddEmployee(int employeeID=0)
        {
            InitializeComponent();

            _employeeID = employeeID;
            tbFirstName.Select();

            if (employeeID != 0)
            {
                var employees = _serializer.DeserializeFromFile_NewJson();
                var employee = employees.FirstOrDefault(x => x.EmployeeId == employeeID);

                if (employee == null)
                    throw new Exception("Brak pracownika o podanym ID");

                tbEmployeeID.Text = employeeID.ToString();
                tbFirstName.Text = employee.FirstName;
                tbLastName.Text = employee.LastName;
                tbSalary.Text = employee.Salary.ToString();
                rtbRemarks.Text = employee.Remarks;
                cbAgreementType.SelectedItem = employee.Contract;
                dtpHireDate.Value = employee.EmploymentDate;
                dtpWorkTermination.Value = (DateTime)employee.UnemploymentDate;
                cbIsActiveEmployee.Checked = employee.IsActive;
            }
        }


        private void btConfirm_Click(object sender, EventArgs e)
        {
            var employees = _serializer.DeserializeFromFile_NewJson();

            if (_employeeID != 0)
            {
                employees.RemoveAll(x => x.EmployeeId == _employeeID);
            }
            else
            {
                var employeeWithHighestID = employees.OrderByDescending(x => x.EmployeeId).FirstOrDefault();
                _employeeID = employeeWithHighestID == null ? 1 : employeeWithHighestID.EmployeeId + 1;
            }

            Employee employee = new Employee()
            {
                EmployeeId = _employeeID,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Contract = cbAgreementType.SelectedIndex.ToString(),
                Remarks = rtbRemarks.Text,
                Salary = Convert.ToDecimal(tbSalary.Text),
                EmploymentDate = DateTime.Now,
                UnemploymentDate = DateTime.Now,
                IsActive = true,
            };

            employees.Add(employee);
            
            _serializer.SerializeToFile_NewJson(employees);

            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
