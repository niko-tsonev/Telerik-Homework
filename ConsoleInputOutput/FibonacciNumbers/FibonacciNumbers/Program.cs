using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int counter = int.Parse(Console.ReadLine());

            decimal numone = 0m;
            decimal numtwo = 1m;
            decimal sum;

            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ", numone);

                sum = numone + numtwo;
                numone = numtwo;
                numtwo = sum;
            }
        }
    }
}
