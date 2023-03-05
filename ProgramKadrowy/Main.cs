using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramKadrowy
{
    public partial class Main : Form
    {
        private JSONSerializers _serializers = new JSONSerializers();
        
        public Main()
        {
            InitializeComponent();
            //SerializersJSONTest();
            dgvEmployeesGrid.DataSource = _serializers.DeserializeFromFile_NewJson();
        }

        public void SerializersJSONTest()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Jan",
                    LastName="Zięba",
                    Remarks="Test",
                },
                new Employee()
                {
                    FirstName="Zofia",
                    LastName="Zięba",
                    Remarks="Test",
                }
            };
            _serializers.SerializeToFile_NewtonSoft(employees);
            _serializers.SerializeToFile_NewJson(employees);

            //List<Employee> employees1= _serializers.DeserializeFromFile_NewtonSoft().ToList();
            var employees2 = _serializers.DeserializeFromFile_NewJson();

            //dgvEmployeesGrid.DataSource = employees1;
            dgvEmployeesGrid.DataSource = employees2;
        }

        


        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void btEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btRefreshGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
