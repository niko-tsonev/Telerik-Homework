using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckABitAtAGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            Console.Write("num: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("pos: ");
            int pos = int.Parse(Console.ReadLine());

            int check = num >> pos;
            int checktwo = num & 1;
            
            bool isOne = checktwo == 1;

            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
            Console.WriteLine("The bit of position {0} is '1': {1}", pos, isOne);
        }
    }
}
