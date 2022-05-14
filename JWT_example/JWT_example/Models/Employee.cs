using System;
namespace JWT_example.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? NationalIDNumber { get; set; }
        public string? EmployeeName { get; set; }
        public string? LoginID { get; set; }
        public string? JobTitle { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Gender { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
    }
}

