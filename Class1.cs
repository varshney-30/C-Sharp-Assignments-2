using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
        internal class Employee
        {
            // Properties
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }

            // Constructor
            public Employee(string name, int age, double salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }

            // Method to display employee details
            public void DisplayDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Salary: ${Salary:F2}");
            }
        }
}
