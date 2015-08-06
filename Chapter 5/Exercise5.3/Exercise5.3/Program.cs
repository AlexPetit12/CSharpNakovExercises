using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._3
{
    class Program
    {
        // Write a program that finds the biggest of three integers, using nested if statements.
        static void Main(string[] args)
        {
            // ask the user three real numbers
            Console.WriteLine("Enter three real numbers: ");

            float valueOne = float.Parse(Console.ReadLine());
            float valueTwo = float.Parse(Console.ReadLine());
            float valueThree = float.Parse(Console.ReadLine());

            // print the biggest of the three numbers
            if (valueOne >= valueTwo)
            {
                if (valueThree >= valueOne)
                {
                    Console.WriteLine("The biggest number is: " + valueThree);
                }
                else
                {
                    Console.WriteLine("The biggest number is: " + valueOne);
                }
            }
            else 
            {
                if (valueThree >= valueTwo)
                {
                    Console.WriteLine("The biggest number is: " + valueThree);
                }
                else
                {
                    Console.WriteLine("The biggest number is: " + valueTwo);
                }
            }

        }
    }
}
