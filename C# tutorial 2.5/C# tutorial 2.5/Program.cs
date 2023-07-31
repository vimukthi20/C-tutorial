using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] userInputs = new int[10];


                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Enter the {0}th number: ", x + 1);
                    userInputs[x] = int.Parse(Console.ReadLine());
                }


                for (int x = 0; x < 10; x++)
                {
                    int number = userInputs[x];

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("{0} is even", number);
                    }
                    else
                    {
                        Console.WriteLine("{0} is odd", number);
                    }
                }
            }
        }
    }
}
