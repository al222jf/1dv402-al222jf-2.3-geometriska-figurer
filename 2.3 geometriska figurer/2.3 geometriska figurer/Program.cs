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
            //Index variabel som används till menyn.
            int index;
            
            do
            {
                //Kallar på menyn som visas när man startar applikationen.
                ViewMenu();
                //Om man använder någon mellan 0-2 så gör switch annars ska den visa felmedelanden.
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <=2)
                {
                    switch(index)
                    {
                        case 0:
                            return;

                        case 1:
                            ViewShapewDetail(CreateShape(ShapeType.Elipse));
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

            //Visar olika headers beroende på vilken "Shape" man valt.
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            if (shapeType == ShapeType.Elipse)
            {
                Console.WriteLine("                 {0}                   ", shapeType);
            }
            else
            {
                Console.WriteLine("                 {0}                ", shapeType);
            }
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");

            Console.ResetColor();

            //Sparar input från ReadDoubleGreaterThanZero så att man inte kan skriva något mindre än 0.
            double lenght = ReadDoubleGreaterThanZero("\nAnge längden: ");
            double width = ReadDoubleGreaterThanZero("Ange Bredden: ");

            //Skickar iväg längd och bredd till den valda "Shape".
            if (shapeType == ShapeType.Elipse)
            {
                return  new Elipse(lenght, width);
            }
            else
            {
                return new Rectangle(lenght, width);
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            //Ett felmedelanden om man skriver in text när man ska använda längd och bredd.
            do
            {
                try
                {
                    Console.Write(prompt);
                    double widthAndLenght = double.Parse(Console.ReadLine());

                    //Kollar så att man inte skriver in något mindre än 0.
                    if (widthAndLenght > 0)
                    {
                        return widthAndLenght;
                    }

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! Ange ett tal större än 0");
                    Console.ResetColor();
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
        private static void ViewMenu()
        {
            //Skriver ut menyn.

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
            //Skriver ut detaljer om vald "Shape".

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
