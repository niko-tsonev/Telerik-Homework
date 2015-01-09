using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWay = "The \"use\" of quotations causes difficulties.";
            string secondWay = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
        }
    }
}
