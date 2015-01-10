using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 10;

            int area = width * height;
            int perimeter = (2 * width) + (2 * height);

            Console.WriteLine("The area is {0}", area);
            Console.WriteLine("This perimeter is {0}", perimeter);
        }
    }
}
