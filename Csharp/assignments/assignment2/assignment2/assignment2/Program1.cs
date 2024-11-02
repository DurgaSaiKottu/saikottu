using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program1
    {
        static void Main(string[] args)
        {
            int number1 = 99, number2 = 55;
            Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
            (number1, number2) = (number2, number1);
            Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
        }
    }
}
