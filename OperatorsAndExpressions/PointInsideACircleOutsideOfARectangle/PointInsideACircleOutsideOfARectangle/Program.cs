using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleOutsideOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Coordinates:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2)) && (x <= 2.5 && x >= -0.5) && (y <= 2.5 && y > 1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
