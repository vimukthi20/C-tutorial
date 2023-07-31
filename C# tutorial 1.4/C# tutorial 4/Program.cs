using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(" Salary Calculator!");


                Console.Write(" employee's salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());


                Console.Write(" tax rate (in percentage): ");
                double Rate = Convert.ToDouble(Console.ReadLine());



                double taxAmount = (salary * Rate) / 100;
                double netSalary = salary - taxAmount;


                Console.WriteLine($"Employee's Salary: ${salary}");
                Console.WriteLine($"Tax Rate: {Rate}%");
                Console.WriteLine($"New Salary after Tax: ${netSalary}");
                Console.ReadKey();
            }
        }
    }
}
