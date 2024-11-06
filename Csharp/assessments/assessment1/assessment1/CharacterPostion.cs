using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    class CharacterPostion
    {
        static string RemoveCharAtPostion(String str, int pos)
        {
            return str.Substring(0, pos) + str.Substring(pos + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveCharAtPostion("Infinite", 1));
            Console.WriteLine(RemoveCharAtPostion("Infinite", 2));
            Console.WriteLine(RemoveCharAtPostion("Infinite", 4));
            Console.Read();
        }
    }
}
