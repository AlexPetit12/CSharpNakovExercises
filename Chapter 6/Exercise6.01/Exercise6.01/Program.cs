using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise6._01
{
    class Program
    {
        // Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        static void Main(string[] args)
        {
            // ask the user for a number
            Console.WriteLine("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            // print the numbers for 1 to N
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
