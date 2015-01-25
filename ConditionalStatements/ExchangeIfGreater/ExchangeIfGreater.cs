namespace ExchangeIfGreater
{
    using System;
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                SwapVariables(ref firstNum, ref secondNum);
            }

            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }

        private static void SwapVariables(ref double firstNum, ref double secondNum)
        {

            double temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }
    }
}
