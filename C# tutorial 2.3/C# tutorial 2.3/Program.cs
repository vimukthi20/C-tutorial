using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Enter the radius of the circle: ");
                int radi = int.Parse(Console.ReadLine());


                double area = Math.PI * radi * radi;
                double circumference = 2 * Math.PI * radi;


                Console.WriteLine(" Area of the circle is: " + area);
                Console.WriteLine(" Circumference of the circle is: " + circumference);
            }
        }
    }
}
