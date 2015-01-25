namespace DigitAsWord
{
    using System;
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitToWord(digit));
        }

        private static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero"; 
                case 1: return "one"; 
                case 2: return "two"; 
                case 3: return "three"; 
                case 4: return "four"; 
                case 5: return "five"; 
                case 6: return "six"; 
                case 7: return "seven";
                case 8: return "eight"; 
                case 9: return "nine"; 
                default: return "Not a digit!"; 
            }
        }
    }
}
