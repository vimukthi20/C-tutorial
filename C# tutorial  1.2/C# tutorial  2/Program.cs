using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter radius for a circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("Area of circle is: " + area);

            }
        }
    }
}
