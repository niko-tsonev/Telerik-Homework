using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.Write("num:");
            int num = int.Parse(Console.ReadLine());

            string i = Convert.ToString(num, 2);

            int check = 1 << 3;
            int checktwo =  num & check;

            if (checktwo == 0)
            {
                Console.WriteLine("Third bit is '0' " + Convert.ToString(num, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(num, 2).PadLeft(16, '0'));
            }
            
        }
    }
}
