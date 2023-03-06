﻿using System;
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
        private JSONSerializers<List<Employee>> _serializer = new JSONSerializers<List<Employee>>();
        private int _employeeID;
        private Employee _employee;
        public AddEmployee(int employeeID=0)
        {
            InitializeComponent();

            _employeeID = employeeID;
            tbFirstName.Select();

            GetEmployeeData(_employeeID);
            
        }

        private void GetEmployeeData(int employeeID)
        {
            if (employeeID != 0)
            {
                Text = "Edytowanie danych pracownika";
                var employees = _serializer.DeserializeFromFile_NewJson();
                _employee = employees.FirstOrDefault(x => x.EmployeeId == employeeID);

                if (_employee == null)
                    throw new Exception("Brak pracownika o podanym ID");

                FillEmployeeData();
            }
        }

        private void FillEmployeeData()
        {
            tbEmployeeID.Text = _employeeID.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbSalary.Text = _employee.Salary.ToString();
            rtbRemarks.Text = _employee.Remarks;
            cbAgreementType.SelectedItem = _employee.Contract;
            dtpHireDate.Value = _employee.EmploymentDate;
            dtpWorkTermination.Value = (DateTime)_employee.UnemploymentDate;
            cbIsActiveEmployee.Checked = _employee.IsActive;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            var employees = _serializer.DeserializeFromFile_NewJson();

            if (_employeeID != 0)
                employees.RemoveAll(x => x.EmployeeId == _employeeID);
            else
                AssignEmployeeHighestID(employees);

            AddNewEmployee(employees);
            
            _serializer.SerializeToFile_NewJson(employees);

            Close();
        }

        private void AssignEmployeeHighestID(List<Employee> employees)
        {
            var employeeWithHighestID = employees.OrderByDescending(x => x.EmployeeId).FirstOrDefault();
            _employeeID = employeeWithHighestID == null ? 1 : employeeWithHighestID.EmployeeId + 1;
        }

        private void AddNewEmployee(List<Employee> employees)
        {
            Employee employee = new Employee()
            {
                EmployeeId = _employeeID,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Contract = cbAgreementType.SelectedIndex.ToString(),
                Remarks = rtbRemarks.Text,
                Salary = decimal.TryParse(tbSalary.Text, out decimal salary) == true ? Convert.ToDecimal(tbSalary.Text) : salary,
                EmploymentDate = DateTime.Now,
                UnemploymentDate = DateTime.Now,
                IsActive = true,
            };

            employees.Add(employee);
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
