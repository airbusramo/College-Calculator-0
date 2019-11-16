using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Calculator_0
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This program will add two numbers together and perfrom an operation of your choosing.");

            //Explaining Operation
            Console.WriteLine("Select your operation.");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Power");
            Console.WriteLine("6: Square Root (Only Takes First Number)");
            Console.WriteLine();
            Console.WriteLine("Enter Selection:");

            //Varaibles for try catch.
            byte operation = 0;
            double num1 = 0, num2 = 0;
            try
            {
                //Inputs
                operation = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Enter First Number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            
            catch (System.FormatException)
            {
                Console.WriteLine("Invailid Input.");
                Restart();
            }

            
        }

        //Method for restarting the program.
        private static void Restart()
        {
            Console.WriteLine();
            Console.WriteLine("Restart? (y/n):");

            try
            {
                char restartInput = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(restartInput))
                {
                    case 'y':
                        Main();
                        break;
                    case 'n':
                        End();
                        break;
                    default:
                        Console.WriteLine("Invaild Input");
                        Restart();
                        break;
                }
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Invaild Input");
                Restart();
            }

        }

        //Method for ending the program.
        private static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
