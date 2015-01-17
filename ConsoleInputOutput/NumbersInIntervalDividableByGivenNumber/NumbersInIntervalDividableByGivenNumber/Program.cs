using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer number: ");
            int numone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Integer number: ");
            int numtwo = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = numone; i <= numtwo; i++)
            {

                if (i % 5 == 0)
                {
                    counter++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("{0} numbers between {1} and {2}", counter, numone, numtwo);
        }
    }
}
