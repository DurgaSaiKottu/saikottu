using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program5
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b) Console.WriteLine(a+b);
            else Console.WriteLine(3*(a+b));
            Console.Read();
        }
    }
}
