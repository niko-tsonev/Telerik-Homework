using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            Console.Write("num: ");
            int num = int.Parse(Console.ReadLine());

            bool check = ((num / 100) % 10 == 7);

            if (check == true) {
                Console.WriteLine("True");
            }
            else if (check == false)
            {
                Console.WriteLine("False");
            }
            else {
                Console.WriteLine("Invalid Input Format.");
            }
        }
    }
}
