using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            string input = Console.ReadLine();

            if (input != null)
            {
                int n = int.Parse(input);

                int c = 1;

                while (c <= 10)
                {
                    int res = n * c;
                    Console.WriteLine(n + " x " + c + " = " + res);
                    c++;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}