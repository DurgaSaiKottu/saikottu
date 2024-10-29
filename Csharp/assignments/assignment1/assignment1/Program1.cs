using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b = Convert.ToInt32(Console.ReadLine());
              if (a == b)
              {
                Console.WriteLine($"{a}and {b} are equal");
                Console.Read();
              }
              else
              {
                Console.WriteLine($"{a}and {b} are not equal");
                Console.Read();

            }

        }
    }
}
