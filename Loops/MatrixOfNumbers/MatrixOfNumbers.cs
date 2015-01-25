namespace MatrixOfNumbers
{
    using System;
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("No matrix can be printed.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write("{0,-4}", j);
                }
                Console.WriteLine();
            }
        }
    }
}
