using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current Date & Time
            DateTime dt = DateTime.Now;

            // Ask the user for their name
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();

            // Show messages
            Console.WriteLine("Hello " + name + "!!!");
            Console.WriteLine("Today is " + dt.ToString());
        }
    }

}
