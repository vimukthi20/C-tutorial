using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your batch: ");
                string batchNo = Console.ReadLine();

                Console.WriteLine(" name is: " + name);
                Console.WriteLine(" batch is: " + batchNo);
            }
        }
    }
}
