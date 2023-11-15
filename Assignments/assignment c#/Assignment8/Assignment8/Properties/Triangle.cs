using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Assignment8
{
    public class Triangle : IShape

    {

        int a = 5;
        int b = 6;
        int c = 7;
        public string GetShapeType()

        {
            return "Triangle";
        }

        public double GetShapeArea()

        {
            return a * b * c;
        }
        public double GetPerimeter()
        {

            return a * b + b * c + c * a;

        }

    }

}
