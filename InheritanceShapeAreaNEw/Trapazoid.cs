using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapeAreaNEw
{
    internal class Trapazoid : Triangle
    {
        public double side;

        private double AreaTrapazoid()
        {
            return ((bottom + side) / 2) * height;
        }

        public string displayAreaTrapazoid()
        {
            return "Area of Trapazoid: " + AreaTrapazoid();
        }

    }
}
