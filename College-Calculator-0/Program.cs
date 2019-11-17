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
            Console.WriteLine("This program will add two numbers together\nand perfrom an operation of your choosing.");

            //Explaining Operation
            Console.WriteLine("Select your operation.");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Power (First Number to the Power of the Second Number)");
            Console.WriteLine("6: Square Root (Only Takes First Number)");
            Console.WriteLine();
            Console.WriteLine("Enter Selection:");

            //Varaibles
            byte operation = 0;
            double num1 = 0, num2 = 0, result = 0;
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
                Console.WriteLine("Invalid Input.");
                Restart();
            }

            //
            char operatorSymbol = '0';

            //Selecting operation and performing it.
            switch (operation)
            {
                case 1:
                    //Addition
                    operatorSymbol = '+';
                    result = num1 + num2;
                    break;
                
                case 2:
                    //Subtraction
                    operatorSymbol = '-';
                    result = num1 - num2;
                    break;

                case 3:
                    //Multiplication
                    operatorSymbol = '*';
                    result = num1 * num2;
                    break;

                case 4:
                    //Division
                    operatorSymbol = '/';
                    result = num1 / num2;
                    break;

                case 5:
                    //Power
                    operatorSymbol = '^';
                    result = Math.Pow(num1, num2);
                    break;
                case 6:
                    //Square Root
                    operatorSymbol = 'r';
                    result = Math.Sqrt(num1);
                    break;

                default:
                    Console.WriteLine("Something went wrong.");
                    Restart();
                    break;
            }

            if (operatorSymbol == 'r')
            {
                Console.WriteLine("The square root of {0} is {1}.", num1, result);
            }
            else
            {
                //Output in the form of num1 operator num2 = result.
                Console.WriteLine("{0} {1} {2} = {3}");
            }

            Restart();
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
