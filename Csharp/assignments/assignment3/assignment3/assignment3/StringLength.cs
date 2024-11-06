using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class StringLength
    {
        public static void Strlen()
        {
            Console.WriteLine("Enter the word : ");
            String word = Console.ReadLine();
            int size = word.Length;
            Console.WriteLine("length of the word : {0} " ,size);
        }
        static void Main(String[] args)
        {
            Strlen();
            Console.Read();

        }

    }
}
