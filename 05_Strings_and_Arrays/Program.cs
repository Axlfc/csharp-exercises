using System;

namespace StringsAndArrays {
    class Program {
        static void Main(string[] args) {
            /* 
            string str;
            string str2 = null;
            string str3 = System.String.Empty;
            string str4 = "";
            string str5= " ";

            // Type and Output
            Console.WriteLine($"str5: {str5}");
            Console.WriteLine(str5.GetType());

            // Array of chars and string
            char[] letters = {"#", "€", "$"};
            Console.WriteLine(letters[0]);
            string str6 = "#€$";
            Console.WriteLine(str6[0]);

            // String concatenation
            string msg1 = "Good morning";
            // some code here
            string msg2 = "I'm programming in C#";

            // print the message
            Console.WriteLine(msg1 + ", " + msg2);

            string msg3 = msg1 + msg2;
            string msg4 = msg1;
            msg4 + msg2;

            // print the full message
            Console.WriteLine(msg4);
            */
            // Literals
            // Special escaped characters -> \n \u00C6 \r \t
            string columns = "Column 1\tColumn 2\tColumn 3";
            Console.WriteLine(columns);
        }
    }
}