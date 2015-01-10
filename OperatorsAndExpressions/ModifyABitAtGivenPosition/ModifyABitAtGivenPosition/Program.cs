using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your number");
            Console.Write("num: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Write a position: ");
            Console.Write("pos: ");
            int pos = int.Parse(Console.ReadLine());
            Console.Write("Value of bit [0 or 1]: ");
            Console.Write("val: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));

            if (value == 1)
            {
                int check = 1 << pos;
                int checkone = num | check;
                Console.WriteLine(Convert.ToString(checkone, 2).PadLeft(16, '0'));
                Console.WriteLine(checkone);
            }
            else
            {
                int checktwo = ~(1 << pos);
                int checkzero = num & checktwo;
                Console.WriteLine(Convert.ToString(checkzero, 2).PadLeft(16, '0'));
                Console.WriteLine(checkzero);
            }
        }
    }
}
