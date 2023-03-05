using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgramKadrowy
{
    public partial class Main : Form
    {
        private JSONSerializers serializers=new JSONSerializers();
        
        public Main()
        {
            InitializeComponent();
            //SerializersJSONTest();
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
            serializers.SerializeToFile_NewtonSoft(employees);
            serializers.SerializeToFile_NewJson(employees);

            //List<Employee> employees1= serializers.DeserializeFromFile_NewtonSoft();
            var employees2 = serializers.DeserializeFromFile_NewJson();

            //dgvEmployeesGrid.DataSource= employees1;
            dgvEmployeesGrid.DataSource = employees2;
        }

        


        private void btAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btRefreshGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
