using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevidedBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            Console.Write("num: ");
            int num = int.Parse(Console.ReadLine());

            bool boolnum = num % 7 == 0 && num % 5 == 0;

            if (boolnum == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    }
}
