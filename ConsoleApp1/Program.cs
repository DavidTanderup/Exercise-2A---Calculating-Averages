using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostAreAverage;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p = new Class1();
            //p.Addition(10);
            bool displayMenu = true;
            while (displayMenu)
            {
                Console.Clear();
                displayMenu = MainMenu();

            }
        }

        private static bool MainMenu()
        {
            Program p = new Program();
            string input = "Welcome to the Main Menu\nPlease limit your number selection to the range of 1-100\n" +
                           "\t1 Addition...Your favorite 10 numbers\n" +
                           "\t2 Averages...The Average of your favorite 10 numbers\n" +
                           "\t3 Grading...boring..(you tell me how many grades you have to enter)\n" +
                           "\t4 Grading...Exciting!! Just enter your grades and I'll figure it out\n" +
                           "\t5 Exit...You can only handle so much fun in a day.";
            Console.WriteLine(input);
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                p.SumOfAllNumbers();
                Console.ReadLine();
                return true;
            }
            else if (result == "2")
            {
                Console.Clear();
                p.MostPeopleAreHere();
                Console.ReadLine();
                return true;
            }
            else if (result == "3")
            {
                Console.Clear();
                p.TheGradesAreFixed();
                Console.ReadLine();
                return true;
            }
            else if (result == "4")
            {
                Console.Clear();
                p.HotelCalifornia();
                Console.ReadLine();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }

        // Sum of numbers
        public double SumOfAllNumbers()
        {
            Console.WriteLine("Welcome to Addition!! \n\nHit Enter to continue.");
            Class1 class1 = new Class1();
            int value = 10;

            Console.ReadLine();
            return (class1.Addition(value));

        }

        // Average ten scores
        public double MostPeopleAreHere()
        {
            Console.WriteLine("Top Ten Average!!");
            Console.WriteLine("\nHit Enter to continue...");
            Class1 class1 = new Class1();
            Console.ReadLine();
            double value = class1.Addition(10);
            double average = value / 10;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your student's average is {class1.Average(value, 10) / 100:P} resulting in a {class1.LetterGrade(average)}");
            return (class1.Average(value, 10));
        }

        //Average specific number of scores.
        public double TheGradesAreFixed()
        {
            Class1 class1 = new Class1();

            Console.WriteLine("The Grades are fixed and the results don't matter\n\nMostly...");
            Console.WriteLine("\nHit Enter to continue...");

            Console.ReadLine();
            Console.Write("How many Grades do you have to enter?: ");
            double count = double.Parse(Console.ReadLine());
            double value = class1.Addition(count);
            double average = value / count;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your student's average is {class1.Average(value, 10) / 100:P} resulting in a {class1.LetterGrade(average)}");
            return (class1.Average(value, count));
        }

        //Ask about a TRY CATCH or another way to limit inputs
        //Unlimited grades
        public (double average, string letterGrade) HotelCalifornia()
        {
            Class1 class1 = new Class1();

            bool complete = true;
            // use the count to provide the value for my average
            int count = -1;
            int index = 1;
            double grade = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to Hotel California \n.....\n.....We've checked you in.");
                Console.WriteLine($"\nType the word \"Complete\" to exit");
                Console.Write($"\nPlease enter grade #{index}: ");
                var input = Console.ReadLine();

                if (input == "Complete")
                {
                    complete = false;
                }
                else
                {

                    grade = grade + Convert.ToInt32(input);
                }
                index++;
                count++;
            } while (complete);
            double average = grade / count;
            string letterGrade = class1.LetterGrade(average);
            Console.WriteLine($"Your student's average is {Math.Round(average, 2) / 100:P} which earns them the lettergrade of {letterGrade}");

            return (average, letterGrade);

        }


    }
}
