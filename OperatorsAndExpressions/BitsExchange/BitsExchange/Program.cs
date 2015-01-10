using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your number");
            Console.Write("num:");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            int checkone = 3;
            int checktwo = 24;

            for (int i = 0; i < 3; i++)
            {
                long maskone = (num & (1 << checkone)) >> checkone;
                long masktwo = (num & (1 << checktwo)) >> checktwo;

                if (maskone == 0)
                {
                    num = num & (~(1 << checktwo));
                }
                else if (maskone == 1)
                {
                    num = num | (1 << checktwo);
                }

                if (masktwo == 0)
                {
                    num = num & (~(1 << checkone));
                }
                else if (masktwo == 1)
                {
                    num = num | (1 << checkone);
                }

                checkone++;
                checktwo++;
            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}
