using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Ch_13_Employee_1
{
    internal class Employee
    {
        // Properties
        public string Name { get; private set; }
        public DateTime Birthdate { get; private set; }
        public decimal HourlySalary { get; private set; }
        public string JobTitle { get; private set; }
        public decimal TaxRate { get; private set; }

        // Constructors
        public Employee(string name, DateTime birthdate, decimal hourlySalary, string jobTitle)
        {
            Name = name;
            Birthdate = birthdate;
            HourlySalary = hourlySalary;
            JobTitle = jobTitle;
            TaxRate = 0.25m;
        }

        public Employee(string name, DateTime birthdate, string jobTitle, decimal hourlyPayRate)
            : this(name, birthdate, hourlyPayRate, jobTitle) { }

        public Employee(string name, DateTime birthdate, decimal hourlySalary, string jobTitle, decimal taxRate)
        {
            Name = name;
            Birthdate = birthdate;
            HourlySalary = hourlySalary;
            JobTitle = jobTitle;
            TaxRate = taxRate;
        }

        // ToString method
        public override string ToString()
        {
            return $"Name: {Name} \n\nBirthdate: {Birthdate:d} \n\nJob Title: {JobTitle} \n\nHourly Salary: {HourlySalary:c}";
        }
    }
}
