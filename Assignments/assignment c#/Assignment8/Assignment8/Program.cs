using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Assignment8
{
    class Program
    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter Shape Type :");
            string shapeType = Console.ReadLine();
            IShape ss = ShapeFactory.GetShapes(shapeType);

            if (ss != null)

            {

                Console.WriteLine("Shape Type : {0}", ss.GetShapeType());
                Console.WriteLine("Shape Area : {0}", ss.GetShapeArea());
                Console.WriteLine("Perimeter : {0}", ss.GetPerimeter());

            }

            else

            {
                Console.WriteLine("Invalid Shape.. please give correct type");
            }

            Console.Read();

        }

    }

}