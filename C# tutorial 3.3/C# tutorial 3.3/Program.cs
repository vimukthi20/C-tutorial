using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            int sum = 0;


            for (int i = 0; number > 0; i++)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }


            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
