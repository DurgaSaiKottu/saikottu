using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class ReverseString
    {
        public static void RevStr()
        {
            Console.WriteLine("Enter the Word : ");
 
            String word = Console.ReadLine();
 
            String s1 = " ";
 
            for(int i = word.Length-1; i >= 0; i--)
            {
                s1 = s1 + word[i];
            }
 
                Console.WriteLine("Reverse String : {0} ", s1);
    }
        public static void Main()
        {
            RevStr();
            Console.Read();
        }
    }
}
