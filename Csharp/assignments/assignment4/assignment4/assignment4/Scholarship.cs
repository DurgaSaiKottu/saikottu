using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{   class Exception_Marks : ApplicationException
    {
        public Exception_Marks(string msg) : base(msg) 
        {
        }
    }
    class Scholarship
    {
        public int Merit(int marks, int fee) 
        {
            if (marks >= 70 && marks <= 80) 
            {
                return (fee * 20) / 100;
            }
            else if (marks >= 80 && marks <= 90)
            {
                return (fee * 30) / 100;
            }
            else if (marks > 90)
            {
                return (fee * 50) / 100;
            }
            return 0;
        }
        class Marks_Exception
        {
            static void Main(String[] args) 
            {
                Console.WriteLine("enter the marks");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the fee");
                int f = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if ( m > 100)
                    {
                        throw (new Exception_Marks("Enter The Below 100"));
                    }

                }
                catch( Exception_Marks msg)
                {
                    Console.WriteLine(msg.Message);
                }
                Scholarship obj = new Scholarship();
                Console.WriteLine( obj.Merit(m,f));
                Console.Read();
            }
        }
        
    }
}
