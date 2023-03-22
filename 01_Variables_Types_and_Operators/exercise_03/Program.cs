using System;

namespace VariablesTypesAndOperators {
    class Program {
        static void Main(string[] args) {
            // Operators Determines the operators to check for the following conditions:
            // - A number is greater than or equal to 18
            // - A char is 'a'
            // - Two conditions are fulfilled at the same time (both true)
            // - One of two conditions is true at the same time (one true and one false)

            // Note: you can write this data by console if you prefer to see it. The idea of the exercise is to store the data in the most suitable types.


            // Operators
            // Arithmetic: +, -, *, /
            // Autoincrement ++, Autodecrement --

            // Assignation: +=, -=, *=, etc.

            // Comparation: < > <= >= == !=

            // Logical: &&, ||, !

            int n = 22;
            char letter = 'a';

            bool condition_1 = (n>=18);
            bool condition_2 = (letter=='a');
            bool condition_3 = (condition_1 && condition_2);
            bool condition_4 = (condition_3 || false);

            Console.WriteLine("Number is greater than or equal to 18 = " + condition_1);
            Console.WriteLine("A char is 'a' = " + condition_2);
            Console.WriteLine("Two conditions are fulfilled at the same time (both true) = " + condition_3);
            Console.WriteLine("One of two conditions is true at the same time (one true and one false) = " + condition_4);
        }
    }
}
