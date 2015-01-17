using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numbers :");
            string stringone = Console.ReadLine();
            double sum = 0;
            string[] Numbers = stringone.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += double.Parse(Numbers[i]);
            }

            Console.WriteLine("sum: {0}", sum);
        }
    }
}
