using System;
using static System.Console;

namespace codetest3
{
    class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int l, int b)
        {
            Length = l;
            Breadth = b;
        }
        public static Box AddBoxes(Box box1,Box box2)
        {
            int sumLength = box1.Length + box2.Length;
           int sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }
        public void DisplayDetails()
        {
            WriteLine("Length:" + Length);
            WriteLine("Breadth:" + Breadth);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            WriteLine("length of 1st box:");
           int l1 = int.Parse(ReadLine());

            WriteLine("breadth of 1st box:");
          int b1 = int.Parse(ReadLine());

            WriteLine("length of 2nd box:");
            int l2 = int .Parse(ReadLine());

            WriteLine("breadth of 2nd box:");
            int b2 = int.Parse(ReadLine());

            Box box1 = new Box(l1, b1);
            Box box2 = new Box(l2, b2);

            Box box3 = Box.AddBoxes(box1, box2);
            WriteLine("3rd box details:");

            box3.DisplayDetails();


        }
    }
}
