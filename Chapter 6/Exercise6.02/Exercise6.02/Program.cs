using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise6._02
{
    class Program
    {
        // Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
        static void Main(string[] args)
        {
            // ask the user for a number
            Console.WriteLine("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            // print the numbers not divisible by 3 nor by 7
            for (int i = 1; i <= N; i++)
            { 
                if(i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i + " is not divisble by 3 nor by 7.");
                }
            }
        }
    }
}
