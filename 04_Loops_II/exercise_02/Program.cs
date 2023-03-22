using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a list of programming languages, for example: C#, Java, C++. Presents the list to the console and asks the user to select the language using 1, 2, 3 or a, b, c. Present the result in console.

            // Note: you can add “Hello world” to the result for C#.

            List<string> languages = new List<string> {"Python", "Bash", "Powershell", "Dart", "Java", "C#", "C++", "C"};

            // Display list of programming languages to console
            Console.WriteLine("Select a programming language:");
            for (int i = 0; i < languages.Count; i++) {
                Console.WriteLine($"{i+1}. {languages[i]}");
            }

            // Prompt user to select language
            Console.Write("Selection: ");
            string input = Console.ReadLine().ToLower();

            switch(input) {
                case "1":
                case "a":
                    Console.WriteLine("You selected Python");
                    break;
                case "2":
                case "b":
                    Console.WriteLine("You selected Bash");
                    break;
                case "3":
                case "c":
                    Console.WriteLine("You selected Powershell");
                    break;
                case "4":
                case "d":
                    Console.WriteLine("You selected Dart");
                    break;
                case "5":
                case "e":
                    Console.WriteLine("You selected Java");
                    break;
                case "6":
                case "f":
                    Console.WriteLine("Hello, world");
                    break;
                case "7":
                case "g":
                    Console.WriteLine("You selected C++");
                    break;
                case "8":
                case "h":
                    Console.WriteLine("You selected C");
                    break;
            }
        }
    }
}