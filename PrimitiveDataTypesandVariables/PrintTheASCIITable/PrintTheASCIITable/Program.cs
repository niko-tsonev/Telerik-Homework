using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char asciiCharacter = '\u0000';
            for (int i = 0; i < 256; i++)
            {
                Console.Write("{0}. {1}; ", i, asciiCharacter);
                asciiCharacter++;
            }
        }
    }
}
