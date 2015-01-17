using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double radius = double.Parse(Console.ReadLine());

            double resultPer = 2 * Math.PI * radius;
            double resultArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The perimeter is: {0}\nThe area is: {1}", resultPer, resultArea);
        }
    }
}
