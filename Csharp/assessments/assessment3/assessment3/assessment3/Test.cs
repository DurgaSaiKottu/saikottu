using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double length, double breadth) 
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the  first Box Details:");
            Console.WriteLine($"Length:");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Breadth:");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Enter the  second Box Details:");
            Console.WriteLine($"Length:");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Breadth:");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Box box2 = new Box(length1, breadth1);

            Console.WriteLine("---------------------------------");
            Box box3 = Box.AddBoxes(box1, box2);

            Console.WriteLine($"third box details ( sum of the first and second boxes):");
            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
