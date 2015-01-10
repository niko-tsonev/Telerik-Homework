using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpull = 0.17;
            Console.WriteLine("Your weight on Earth");
            Console.Write("KG: ");
            double earthWeight = double.Parse(Console.ReadLine());

            double moonWeight = earthWeight * gpull;

            Console.WriteLine(moonWeight);
            
        }
    }
}
