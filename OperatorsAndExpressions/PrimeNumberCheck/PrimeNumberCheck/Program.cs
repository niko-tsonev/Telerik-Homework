using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                int primeCount = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        primeCount++;
                    }
                }

                bool isPrime = true;

                if (primeCount > 2)
                {
                    isPrime = false;
                }

                Console.WriteLine(isPrime);
            }
        }
    }
}
