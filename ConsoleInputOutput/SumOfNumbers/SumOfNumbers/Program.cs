using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (double i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the {0} number", i + 1);
                double value = double.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("sum: {0}", sum);
        }
    }
}
