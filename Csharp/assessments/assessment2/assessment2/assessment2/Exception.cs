using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class Exception
    {
        static void CheckIfNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number cannot be negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter the number");
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckIfNegative(number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception :" + ex.Message);
            }
            catch (FormatException) 
            {
                Console.WriteLine(" Enter a proper valid integer");
            }
            Console.Read();
        }
    }
}
