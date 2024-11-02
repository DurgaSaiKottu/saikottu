using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class program4
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 7, 6, 1, 3 };
            double average = arr.Average();
            Console.WriteLine("Average value is: " + average);
            int minValue = arr.Min();
            Console.WriteLine("Minimum value is: " + minValue);
            int maxValue = arr.Max();
            Console.WriteLine("Maximum value is: " + maxValue);
            Console.ReadLine();
        }
    }
}
