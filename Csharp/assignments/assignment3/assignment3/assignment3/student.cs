using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Student
    {
        public string Rollno;
        public string Name;
        public string Class;
        public string Semester;
        public string Branch;

        public Student(string roll_no, string name, string Std_class, string sem, string branch)
        {
            Rollno = roll_no;
            Name = name;
            Class = Std_class;
            Semester = sem;
            Branch = branch;
        }
        public void Studentdetails()
        {
            Console.WriteLine("*** Student Details ***");
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Roll no : {0}", Rollno);
            Console.WriteLine("Class : {0}", Class);
            Console.WriteLine("Semester : {0}", Semester);
            Console.WriteLine("Branch : {0}", Branch);
        }
    }

    class Marks : Student
    {
        public Marks(string roll_no, string name, string Std_class, string sem, string branch) : base(roll_no, name, Std_class, sem, branch)
        {

        }
        
        public int[] marks = new int[5];
        public void Getmarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} marks : ", i);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        public void DisplayResult()
        {
            Console.WriteLine(" ");
            int Total_marks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                Total_marks += marks[i];
            }
            Console.WriteLine("*** Total marks ***");
            Console.WriteLine("Total marks : {0} ", Total_marks);
            Console.WriteLine(" ");
            Console.WriteLine("*** Average percentage ***");
            float average = (Total_marks / marks.Length);
            Console.WriteLine("Average of all marks : {0}", average);


            foreach (int i in marks)
            {
                if (i > 35 && average > 50) Console.WriteLine("Pass");
                else Console.WriteLine("Fail");
            }
        }

        public void DisplayData()
        {
            Studentdetails();
            DisplayResult();
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Console.Write("Enter Student name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Student Roll No : ");
            string Rollno = Console.ReadLine();
            Console.Write("Enter Student Class : ");
            string Class = Console.ReadLine();
            Console.Write("Enter Which Semester : ");
            string sem = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string branch = Console.ReadLine();
            Marks mark = new Marks(Name, Rollno, Class, sem, branch);
            Console.WriteLine(" ");
            Console.WriteLine("*** Get marks ***");
            mark.Getmarks();
            Console.WriteLine(" ");
            mark.DisplayData();
            Console.ReadKey();
        }
    }

}