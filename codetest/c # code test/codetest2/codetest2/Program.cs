using System;
using static System.Console;

namespace codetest2
{
    abstract class student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double grade { get; set; }

        public abstract bool IsPassed(double grade);

        
    }
    class Undergraduate : student
    {
        public override bool IsPassed(double grade)
        {
            return grade <= 70.0;
        }
    }
    class Graduate:student
    {
        public override bool IsPassed(double grade)
        {
            return grade <= 80.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            WriteLine("enter name:");
            string Name = ReadLine();
            WriteLine("enter student id:");
            int StudentId =Convert.ToInt32( ReadLine());
            WriteLine("enter grade:");
            double Grade =Convert.ToDouble(ReadLine());


            Graduate graduate = new Graduate();

            WriteLine("enter name:");
            string name = ReadLine();
            WriteLine("enter student id:");
            int studentId = Convert.ToInt32(ReadLine());
            WriteLine("enter grade:");
            double grade = Convert.ToDouble(ReadLine());

            WriteLine($"{undergraduate.Name}passed:{undergraduate.IsPassed(undergraduate.grade)}");
            WriteLine($"{graduate.Name}passed:{graduate.IsPassed(graduate.grade)}");



        }
    }
}
