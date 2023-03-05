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
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            var employees = _serializer.DeserializeFromFile_NewJson();
            var employeeWithHighestID = employees.OrderByDescending(x => x.EmployeeId).FirstOrDefault();
            var employeeID = employeeWithHighestID == null ? 1 : employeeWithHighestID.EmployeeId + 1;

            Employee employee = new Employee()
            {
                EmployeeId = employeeID,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Contract = cbAgreementType.SelectedIndex.ToString(),
                Remarks=rtbRemarks.Text,
                Salary = Convert.ToDecimal(tbSalary.Text),
                EmploymentDate= DateTime.Now,
                UnemploymentDate=DateTime.Now,
                IsActive=true,
            };

            employees.Add(employee);
            _serializer.SerializeToFile_NewJson(employees);
            Close();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
