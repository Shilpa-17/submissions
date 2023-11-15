
using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace Assignment8

{

    public class Rectangle : IShape

    {

        int length = 5;
        int breadth = 10;
        int height = 12;

        public string GetShapeType()

        {
            return "Rectangle";
        }
        public double GetShapeArea()

        {
            return length * breadth * height;

        }
        public double GetPerimeter()

        {
            return 2 * (length + breadth);

        }

    }

}
