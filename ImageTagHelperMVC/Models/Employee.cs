namespace ImageTagHelperMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }       // Unique identifier for the employee
        public string Name { get; set; }    // Employee's name
        public Gender gender { get; set; }
        public string Position { get; set; }      // Job title or position
        public string Department { get; set; }    // Department the employee belongs to
        public string Email { get; set; }         // Employee's email address
        public string Phone { get; set; }         // Employee's phone number
        public DateTime DateOfBirth { get; set; } // Employee's date of birth
        public DateTime DateOfJoining { get; set; } // Date when the employee joined the company
        public decimal Salary { get; set; }       // Employee's salary
        public string Address { get; set; }       // Employee's residential address
    }

    public enum Gender
    {
        Male,Female
    }
}
