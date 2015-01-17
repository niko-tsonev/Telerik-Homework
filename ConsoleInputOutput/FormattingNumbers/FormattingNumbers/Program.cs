using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numone");
            int a = int.Parse(Console.ReadLine());
            Console.Write("numtwo");
            double b = double.Parse(Console.ReadLine());
            Console.Write("numthree");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
