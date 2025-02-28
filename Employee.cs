// Written by Aicha Maiga 
// 02/26/2025



using System;
using System.Collections.Generic;


namespace HW5EmployeesandSpecializations
{
    public abstract class Employee
    {
        private string name = "n/a";
        private double salary = 0;

        public string Name 
        { 
            get { return this.name; } 
            set { this.name = value; } 
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // constructor
        public Employee(string aName, double aSalary)
        {
            this.Name = aName;
            this.Salary = aSalary;
        }

        // method
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}";
        }
    }
}
