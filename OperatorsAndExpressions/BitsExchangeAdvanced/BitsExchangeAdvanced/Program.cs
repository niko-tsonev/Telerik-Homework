using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchangeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            long n = long.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            if (p + k >= 32)
            {
                Console.WriteLine("Out of range");
            }
            else if (p < q && ((p + q) < k))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    int maskone = (int)(n & (1 << p)) >> p;
                    int masktwo = (int)(n & (1 << q)) >> q;

                    //mask one
                    if (maskone == 0)
                    {
                        n = n & (~(1 << q));
                    }
                    else if (maskone == 1)
                    {
                        n = n | (1 << q);
                    }

                    //mask two
                    if (masktwo == 0)
                    {
                        n = n & (~(1 << p));
                    }
                    else if (masktwo == 1)
                    {
                        n = n | (1 << p);
                    }

                    p++;
                    q++;
                }

                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine(n);
            }
        }
    }
}
