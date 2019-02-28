using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostAreAverage
{
    public class Class1
    {
        public string LetterGrade(double value)
        {
            if (value > 90)
            {
                return "A";
            }
            else if (value < 90 && value >= 80)
            {
                return "B";
            }
            else if (value < 80 && value >= 70)
            {
                return "C";
            }
            else if (value < 70 && value >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }



        }
        public double Average(double value, double divider)
        {
            return value / divider;
        }
        public double Addition(double value)
        {
            int countUp = 1;
            double total = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You may enter any number between 0 - 100");
                Console.Write($"\nPlease enter #{countUp}: ");
                double input = double.Parse(Console.ReadLine());
                // catches any entries made outside the expected parameters. 
                //This does not catch errors where the user enters text or hit a wrong key
                if (input > 100 || input < 0)
                {
                    while (input > 100 || input < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That number is out of range.");
                        Console.WriteLine("You may enter any number between 0 - 100");
                        Console.Write($"\nPlease re-enter #{countUp}: ");
                        input = double.Parse(Console.ReadLine());
                    }
                }

                value--;
                countUp++;
                total = input + total;


            } while (value > 0);
            Console.ReadLine();
            return total;





        }




    }
}
