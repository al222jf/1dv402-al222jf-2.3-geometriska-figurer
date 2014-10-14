using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_geometriska_figurer
{
    enum ShapeType {indefenit, Elipse, Rectangle};


    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            int index;
            
            do
            {

                ViewMenu();
            
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <=2)
                {
                    switch(index)
                    {
                        case 0:
                            return;

                        case 1:
                            ViewShapewDetail(CreateShape( ShapeType.Elipse));
                            break;

                        case 2:
                            ViewShapewDetail(CreateShape(ShapeType.Rectangle));
                            break;
                    }

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEL! Ange ett nummer mellan 0 och 2");
                    Console.ResetColor();

                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Tryck tangent för att fortsätta");
                Console.ResetColor();
                Console.Clear();

            } while (true);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {


            double lenght = ReadDoubleGreaterThanZero("Ange längd: ");
            double width = ReadDoubleGreaterThanZero("Ange Bredden: ");

            if (shapeType == ShapeType.Elipse)
            {
                Elipse myElipse = new Elipse(lenght, width);
                return myElipse;
            }
            else
            {
                Rectangle myRectangle = new Rectangle(lenght, width);
                return myRectangle;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {


                Console.WriteLine(prompt);
                double widthAndLenght = double.Parse(Console.ReadLine());

                if (widthAndLenght > 0)
                {
                    return widthAndLenght;
                }

                Console.WriteLine("FEL! Ange ett tal större än 0");
            } while (true);

            
        }
        private static void ViewMenu()
        {
           
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Geometriska figurer");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("0. Avsluta.\n\n1. Ellips.\n\n2. Rektangel.");
                Console.WriteLine("-----------------------------------------------");
                Console.Write("\nAnge menyval [0-2]: ");
                Console.ResetColor();

        }
        private static void ViewShapewDetail(Shape shape)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}
