using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment5
{
    class CreateFile
    {
        static void WriteFile()
        {
            FileStream fileStream = new FileStream("File.txt", FileMode.Create, FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(fileStream);

            Console.WriteLine("Enter the Array Size : ");

            int size = Convert.ToInt32(Console.ReadLine());
            string[] word = new string[size];

            for (int i = 0; i < size; i++)
            {
                word[i] = Console.ReadLine();
            }


            for (int i = 0; i < size; i++)
            {
                streamWriter.WriteLine(word[i]);
            }


            streamWriter.Flush();

            streamWriter.Close();

            fileStream.Close();
        }
        static void Main(string[] args)
        {
            WriteFile();
            Console.ReadKey();
        }
    }
}
