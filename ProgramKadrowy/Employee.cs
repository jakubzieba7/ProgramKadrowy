using System;

namespace ProgramKadrowy
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contract { get; set; }
        public string Remarks { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? UnemploymentDate { get; set; }
        public bool IsActive { get; set; }

    }
}
