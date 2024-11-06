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
            string s = "";
            int l = str.Length;
            string fp = Convert.ToString(str[0]);
            string lp = Convert.ToString(str[l - 1]);
            s += lp;
            for (int i = 1; i < str.Length - 1; i++)
            {
                s = s + str[i];
            }
            s += fp;
            Console.WriteLine("the result is {0}", s);
        }
        static void Main()
        {
            progarm2 p2 = new progarm2();
            p2.exchange("durga");
            Console.ReadLine();
        }
    }
}
