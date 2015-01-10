using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            Console.Write("num: ");
            int num = int.Parse(Console.ReadLine());

            int firstDigit = num % 10;
            int secondDigit = (num / 10) % 10;
            int thirdDigit = (num / 100) % 10;
            int fourthDigit = (num / 1000) % 10;

            Console.WriteLine(num);
            Console.WriteLine("The sum of the dogits is " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed the digits are {0} {1} {2} {3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit in front {0} {1} {2} {3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged {0} {1} {2} {3}", fourthDigit, secondDigit, thirdDigit, firstDigit);   
        }
    }
}
