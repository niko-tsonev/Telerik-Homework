using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an integer");
            Console.Write("num: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is Even", a);
            }
            else {
                Console.WriteLine("{0} is Odd", a);
            }
        }
    }
}
