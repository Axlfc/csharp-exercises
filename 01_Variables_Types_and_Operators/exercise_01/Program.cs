using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives data from a person and generates a message, use a variable for each data and another for the message. 
            // Eg: number, last name, age, knows how to program, etc.

            // Ask the user for their name
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();

            // Ask the user for their last name
            Console.WriteLine("Write your last name:");
            string last_name = Console.ReadLine();

            // Ask the user for their name
            Console.WriteLine("Write your age:");
            string age = Console.ReadLine();

            // Ask the user if they know how to program
            Console.WriteLine("Do you know how to program?");
            string know_to_program = Console.ReadLine();

            // Show messages
        }
    }

}
