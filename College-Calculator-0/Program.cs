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

            string operationText =
@"1: Addition
2: Subtraction
";

            //Inputs
            Console.WriteLine("Enter First Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select your operation.");
            Console.WriteLine();
            int operation;
        }
    }
}
