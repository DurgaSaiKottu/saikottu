using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    class progarm2
    {
        public void exchange(string str)
        {
            string s1 = "";
            int l = str.Length;
            string a = Convert.ToString(str[0]);
            string b = Convert.ToString(str[l - 1]);
            s1 += b;
            for (int i = 1; i < str.Length - 1; i++)
            {
                s1 = s1 + str[i];
            }
            s1 += b;
            Console.WriteLine("the result is {0}", s1);
        }
        static void Main()
        {
            progarm2 p2 = new progarm2();
            p2.exchange("durga");
            Console.ReadLine();
        }
    }
}
