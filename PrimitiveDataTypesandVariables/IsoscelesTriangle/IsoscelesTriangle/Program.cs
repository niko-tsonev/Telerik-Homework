using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            char copyrightSign = '\u00A9';

            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("   {0}   ", copyrightSign);
                }
                else if (i == 2)
                {
                    Console.WriteLine("  {0} {0}  ", copyrightSign);
                }
                else if (i == 3)
                {
                    Console.WriteLine(" {0}   {0} ", copyrightSign);
                }
                else if (i == 4)
                {
                    Console.WriteLine("{0} {0} {0} {0}", copyrightSign);
                }
            }
         }
       }
}

