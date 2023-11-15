using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8

{
    public class Square : IShape

    {

        int side = 10;
        public string GetShapeType()

        {

            return "square";

        }
        public double GetShapeArea()

        {

            return side * side;

        }



        public double GetPerimeter()
        {
            return 4 * side;

        }


    }

}
