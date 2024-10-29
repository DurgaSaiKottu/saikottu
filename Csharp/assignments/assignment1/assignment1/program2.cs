using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class program2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=0)
            {
                Console.WriteLine("given number is postive" + " " + a);
            }
            else
            {
                Console.WriteLine("given number is negative" + " " + a);
            }
            Console.Read();
        }
    }
}
