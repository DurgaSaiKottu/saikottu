using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=10;i++)
            {
                int x = a * i;
                Console.WriteLine(a+" * "+i + "= "+x);
            }
                Console.Read();
        }
    }
}
