using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        protected Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }
        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : Student
    {
        public Undergraduate (string name, int studentId, double grade)
            : base(name, studentId, grade) { }
        public override bool IsPassed(double grade)
        {
            return Grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public Graduate (string name, int studentId, double grade)
            : base(name, studentId, grade) { }
        public override bool IsPassed(double grade)
        {
            return Grade > 80.0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student UndergradStudent = new Undergraduate("Sai",1111, 79.5);
            Console.WriteLine($"Undergraduate{UndergradStudent.Name} passed: {UndergradStudent.IsPassed(UndergradStudent.Grade)}");

            Student gradStudent = new Graduate("Durga",1112, 83);
            Console.WriteLine($"Graduate{gradStudent.Name} passed: {gradStudent.IsPassed(gradStudent.Grade)}");

            Console.Read();
        }
    }
}
