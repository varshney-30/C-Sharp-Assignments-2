using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The input array must not be empty or null.");
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
    }
}
