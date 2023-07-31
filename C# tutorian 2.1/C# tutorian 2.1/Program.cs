using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorian_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double sum = number1 + number2;
                Console.WriteLine("Sum is: " + sum);

            }
        }
    }
}
