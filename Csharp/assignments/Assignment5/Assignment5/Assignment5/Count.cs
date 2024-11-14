using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment5
{
    class Count
    {
        public static void CountFile()
        {
            FileStream fileStream = new FileStream("File.txt", FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream);

            string path = @"C:\DotNet Assignment\C# Training\Csharp\assignments\Assignment5\Assignment5\Assignment5\bin\Debug/File.txt";

            if (File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine("Number of Lines :" + count);
            }
            else
            {
                Console.WriteLine("File Does Not Exists......");
            }
        }
        static void Main()
        {
            CountFile();
            Console.Read();
        }
    }
}
