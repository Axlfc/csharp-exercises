using System;

namespace Loops {
    class Program {
        static void DrawSquare(int side, char character) {
            for (int i = 0; i < side; i++) {
                for (int j = 0; j < side; j++) {
                    Console.Write(character + " ");
                }
                Console.WriteLine();
            }
        }


        static void DrawFilledRectangle(int width, int height, char character) {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    Console.Write(character + " ");
                }
                Console.WriteLine();
            }
        }


        static void DrawEmptyRectangle(int width, int height, char character) {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1) {
                        Console.Write(character + " ");
                    }
                    else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args) {
            // Write a program that performs these steps:

            // Receive 3 data:
            // broad
            // high
            // filler or not

            // Draw in the console with the same character, for example *, a rectangle of the dimensions entered and use the third data to determine if the rectangle is filled (it has more * inside) or not.
            // In case of receiving the same number n twice, you must draw a square of side n.

            // Challenge: Extend the above program to receive another number that is the number of squares or rectangles to be drawn on the screen. Examples:
            // Input: 2,2,2, padding = true
            // Output:

            // ** **
            // ** **

            // Input: 3, 4, 1, padding = false
            // Output:

            // ***
            // * *
            // * *
            // ***

            Console.Write("Enter the broad dimension: ");
            int broad = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter the high dimension: ");
            int high = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter 1 for a filled rectangle or 0 for an empty rectangle: ");
            int filler = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter the number of rectangles to draw: ");
            int numRectangles = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter the character to use to draw the rectangle(s): ");
            char character = Console.ReadKey().KeyChar;

            Console.WriteLine();

            for (int r = 0; r < numRectangles; r++) {
                if (broad == high) {
                    DrawSquare(broad, character);
                }
                else {
                    if (filler == 1) {
                        DrawFilledRectangle(broad, high, character);
                    }
                    else {
                        DrawEmptyRectangle(broad, high, character);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
