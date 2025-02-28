// Written by Aicha Maiga 
// 02/26/2025

using System;
using System.Collections.Generic;


namespace HW5EmployeesandSpecializations
{
    public class Engineer: Employee
    {
        // variables
        private string specialization = "n/a";

        //gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }


        public Engineer(string aName, double aSalary, string theSpecialization): base(aName, aSalary)
        {
            this.Specialization = theSpecialization;
        }

        public override string ToString()
        {
            return base.ToString() + $", Specialization: {Specialization}";
        }
    }

}

