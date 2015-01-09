using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstword = "Hello";
            string secondword = "World";
            object concatenatedwords = firstword + " " + secondword;
            string finalstring = (string)concatenatedwords;

            Console.WriteLine(finalstring);
        }
    }
}
