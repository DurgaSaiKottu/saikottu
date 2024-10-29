using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program3
    {
        public static void Main()
        {
            Console.WriteLine("Enter input first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sign");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter input second number");
            int b = Convert.ToInt32(Console.ReadLine());
            switch(sign)
            {
                case '+':
                    Console.WriteLine(a + b);
                    Console.Read();
                    break;
            case '-':
                Console.WriteLine(a - b);
                   Console.Read();
                    break;
            case '*':
                 Console.WriteLine(a * b);
                    Console.Read();
                    break;
             case '/':
                 Console.WriteLine(a / b);
                    Console.Read();
                    break;
            default:
                    Console.WriteLine("invalid grade");
                    Console.Read();
                    break;
            }

        }

        
     }
        
 }

