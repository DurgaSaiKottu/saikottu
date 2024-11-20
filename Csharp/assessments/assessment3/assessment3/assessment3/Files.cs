using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment3
{
    class Files
    {
        public static void Main()
        {
            string filePath = "File.txt";

            Console.WriteLine("Enter The Text : ");
            string text = Console.ReadLine();

            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                streamWriter.WriteLine(text);
            }

            Console.WriteLine("Task Completed....");
            Console.ReadLine();

        }
    }
}


