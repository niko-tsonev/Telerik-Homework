using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            Nullable<double> b = null;

            Console.WriteLine("Int a = {0}", a);
            Console.WriteLine("Double b = {0}", b);

            a = 15;
            b = 12.35;
            Console.WriteLine("Int a = {0}", a);
            Console.WriteLine("Double b = {0}", b);
        }
    }
}
