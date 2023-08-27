using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    sealed class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    // Attempt to inherit from the sealed class Car
    // This will result in a compilation error
    //class SportsCar : Car
    //{
    //    public void Race()
    //    {
    //        Console.WriteLine("Sports car is racing.");
    //    }
    //}
}
