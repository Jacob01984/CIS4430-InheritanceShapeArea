using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapeAreaNEw
{
    internal class Square: Shape
    {
        private double AreaSquare()
        {
            return Math.Pow(height, 2);
        }

        public string displayAreaSquare()
        {
            return "Area of Square: " + AreaSquare();
        }

    }
}
