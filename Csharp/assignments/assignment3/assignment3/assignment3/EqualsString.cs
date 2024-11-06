using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class EqualsString
    {
        public static void equals()
        {
            Console.WriteLine("Enter the 1st Word : ");

            String word1 = Console.ReadLine();

            Console.WriteLine("Enter the 2nd Word : ");

            String word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("words are Equal");
            }
            else
            {
                Console.WriteLine("words are not Equal");
            }

        }
        public static void Main()
        {
            equals();
            Console.Read();
        }
    }
}
