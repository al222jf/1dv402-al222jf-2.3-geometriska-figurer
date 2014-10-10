using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_geometriska_figurer
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            ViewMenu();
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            double lenght;
            double width;

            Console.Write("Ange Längden: ");
            lenght = double.Parse(Console.ReadLine());

            Console.Write("Ange Bredden: ");
            width = double.Parse(Console.ReadLine());
            //enum Menu { Avsluta, Elipse, Rektangel };
            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {

        }
        private static void ViewMenu()
        {
            
            Console.WriteLine("0. Avsluta.\n\n1. Ellips.\n\n2. Rektangel.");
            if (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static ViewShapewDetail(Shape shape)
        {

        }
    }
}
