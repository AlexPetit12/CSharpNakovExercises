using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._05
{
    class Program
    {
        // Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
        static void Main(string[] args)
        {
            // ask the user to enter a digit
            Console.WriteLine("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());

            // print the digit as a word
            switch (digit)
            { 
                case 0:
                    Console.WriteLine("Zero");
                    break;

                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                    break;

                case 6:
                    Console.WriteLine("Six");
                    break;

                case 7:
                    Console.WriteLine("Seven");
                    break;

                case 8:
                    Console.WriteLine("Eight");
                    break;

                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
        }
    }
}
