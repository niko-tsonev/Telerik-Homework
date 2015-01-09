using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double constant = 0.000001;
            Console.WriteLine("Enter number:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a > b) {
                Console.WriteLine("a > b");
            }
            else if (a < b) {
                Console.WriteLine("a < b");
            }
        }
    }
}
