using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_geometriska_figurer
{
    class Rectangle : Shape
    {
        public override double Area
        {
            get { return Lenght * Width; }
        }

        public override double Perimeter
        {
            get { return (2 * Lenght) + (2 * Width); }
        }

        public Rectangle(double lenght, double width)
            :base (lenght, width)
        {

        }
    }
}
