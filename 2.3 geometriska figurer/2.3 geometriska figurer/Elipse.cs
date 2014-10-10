using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_geometriska_figurer
{
    class Elipse : Shape
    {
        public override double Area
        {
            get { return (Width / 2) * (Lenght / 2) * Math.PI; }

        }

        public override double Perimiter
        {
            get { return Math.PI * Math.Sqrt(2 * (Lenght / 2) * (Lenght / 2) + 2 * (Width / 2) * (Width / 2)); }
        }

        public Elipse(double length, double width)
            :base (length, width)
        {
          
        }
        
    }
}
