using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numone");
            double numone = double.Parse(Console.ReadLine());
            Console.WriteLine("numtwo");
            double numtwo = double.Parse(Console.ReadLine());

            double max = Math.Max(numone, numtwo);
            Console.WriteLine("The greater number is: {0}\n", max);

            double absMax = ((numone + numtwo + Math.Abs(numone - numtwo)) / 2);
            Console.WriteLine("The greater number is: {0}", absMax);

        }
    }
}
