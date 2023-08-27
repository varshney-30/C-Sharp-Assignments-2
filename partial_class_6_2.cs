using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    public partial class Employee1
    {
        // Method to calculate salary based on years of work
        public double CalculateSalary()
        {
            double salary = BaseSalary;

            if (YearsOfWork >= 5)
            {
                salary += 1000; // Additional bonus for employees with 5 or more years of work
            }

            return salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Base Salary: ${BaseSalary:F2}");
            Console.WriteLine($"Years of Work: {YearsOfWork}");
            Console.WriteLine($"Calculated Salary: ${CalculateSalary():F2}");
        }
    }         

}
