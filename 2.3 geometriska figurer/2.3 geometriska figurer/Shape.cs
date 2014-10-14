using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_geometriska_figurer
{
    public abstract class Shape
    {
        private double _lenght;
        private double _width;

        public abstract double Area
        {
            get;
        }

        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (_lenght < 0)
                {
                    throw new ArgumentException();
                }

                _lenght = value;
            }
        }

        public abstract double Perimeter
        {
            get;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (_width < 0)
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }

        protected Shape(double lenght, double width)
        {
            _lenght = lenght;
            _width = width;
        }

        public string ToString()
        {
            return string.Format("\n{0,-7}:{1,10:F2}\n{2,-7}:{3,10:F2}\n{4,-7}:{5,10:F2}\n{6,-7}:{7,10:F2}\n", "Längd", Lenght, "Bredd", Width, "Omkrets", Perimeter, "Area", Area);
        }
    }
}
