using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("h = ");
            int h = int.Parse(Console.ReadLine());

            int result = ((a + b) / 2) * h;

            Console.WriteLine("The area is {0}", result);
        }
    }
}
