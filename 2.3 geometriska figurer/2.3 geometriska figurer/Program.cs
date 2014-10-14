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
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2");
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTryck tangent för att fortsätta");
                Console.ResetColor();
                Console.ReadKey(true);

            } while (true);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            if (shapeType == ShapeType.Elipse)
            {
                Console.WriteLine(" ╔══════════════════════════════════════╗ ");
                Console.WriteLine("                 {0}                   ", shapeType);
                Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            }
            else
            {
                Console.WriteLine(" ╔══════════════════════════════════════╗ ");
                Console.WriteLine("                 {0}                ", shapeType);
                Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            }

            Console.ResetColor();

            do
            {


                try
                {
                    double lenght = ReadDoubleGreaterThanZero("\nAnge längden: ");
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
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange bara siffror.");
                    Console.ResetColor();
                }
            } while (true);
            

            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {

                Console.Write(prompt);
                double widthAndLenght = double.Parse(Console.ReadLine());

                if (widthAndLenght > 0)
                {
                    return widthAndLenght;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Ange ett tal större än 0");
            } while (true);
        }
        private static void ViewMenu()
        {
           
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ╔══════════════════════════════════════╗ ");
                Console.WriteLine(" ║           Geometriska figurer        ║ ");
                Console.WriteLine(" ╚══════════════════════════════════════╝ ");
                Console.ResetColor();
                Console.WriteLine("\n0. Avsluta.\n\n1. Ellips.\n\n2. Rektangel.\n");
                Console.WriteLine("-----------------------------------------");
                Console.Write("\nAnge menyval [0-2]: ");
                Console.ResetColor();
        }
        private static void ViewShapewDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║               Detaljer               ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("-----------------------------------------");
        }
    }
}
