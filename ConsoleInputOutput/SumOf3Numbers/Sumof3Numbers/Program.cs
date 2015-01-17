using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumof3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double numone = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double numtwo = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double numthree = double.Parse(Console.ReadLine());

            double result = numone + numtwo + numthree;

            Console.WriteLine(result); 
        }
    }
}
