using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapeAreaNEw
{
    internal class Triangle: Shape
    {
        public double bottom;

        private double AreaTriangle()
        {
            return (bottom * height) / 2;
        }

        public string displayAreaTriangle()
        {
            return "Area of Triangle: " + AreaTriangle();
        }

    }
}
