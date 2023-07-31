using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an upper limit: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());


            int sum = 0;


            for (int a = 1; a <= upperLimit; a += 2)
            {
                sum += a;
            }


            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
