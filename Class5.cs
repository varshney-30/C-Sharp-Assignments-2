using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    public partial class Person
    {
        public void PrintFullName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Full Name: {fullName}");
        }
    }
}
