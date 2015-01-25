namespace MinMaxSumAverage
{
    using System;
    using System.Linq;
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers count: ");
            int count = int.Parse(Console.ReadLine());

            if (count < 1)
            {
                Console.WriteLine("No numbers to work with.");
                return;
            }

            Console.WriteLine("Enter {0} numbers on separate lines: ", count);
            int[] numbers = Enumerable.Range(0, count)
                .Select(x => int.Parse(Console.ReadLine()))
                .ToArray();

            Console.WriteLine(GetResult(numbers));
        }

        private static string GetResult(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            long sum = numbers.Sum();
            double average = (double)sum / numbers.Length;

            return String.Format(@"
Min     {0}
Max     {1}
Sum     {2}
Average {3:F2}
", min, max, sum, average).Trim();
        }
    }
}
