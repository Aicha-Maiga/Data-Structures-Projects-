// Written by Aicha Maiga 
// 02/26/2025


using System;
using System.Collections.Generic;


namespace HW5EmployeesandSpecializations
{
    public class Manager: Employee
    {
        private int numberofEmployeesManaged = 0;

        public int NumberofEmployeesManaged
        {
            get { return numberofEmployeesManaged; }
            set { numberofEmployeesManaged = value; }
        }

        public Manager( string aName, double aSalary, int theNumberofEmployeesManaged):base(aName, aSalary)
        {
            this.NumberofEmployeesManaged = theNumberofEmployeesManaged;

        }

        public override string ToString()
        {
            return base.ToString() + $", Manages: {NumberofEmployeesManaged} employees";
        }

    }
}
