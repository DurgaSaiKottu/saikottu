using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    class program3
    {
       static int  FindLargest(int a,int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static void Main()
        {
            Console.WriteLine(FindLargest(1, 2, 3));
            Console.WriteLine(FindLargest(5, 6, 3));
            Console.WriteLine(FindLargest(9, 2, 3));
            Console.WriteLine(FindLargest(1, 6, 3));
        }
    }
}
