using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            Console.WriteLine("Enter one or more numbers, one per line:");
            Console.WriteLine("(Enter an empty line to stop)");

            while (true)
            {
                string input = Console.ReadLine() ?? "";

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int number = int.Parse(input);

                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
                else if (number == 0)
                {
                    zeroCount++;
                }
            }

            Console.WriteLine("Positive numbers: " + positiveCount);
            Console.WriteLine("Negative numbers: " + negativeCount);
            Console.WriteLine("Zero: " + zeroCount);
        }
    }
}