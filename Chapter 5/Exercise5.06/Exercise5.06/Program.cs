using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._06
{
    class Program
    {
        // Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
        static void Main(string[] args)
        {
            // ask the user for the values of a, b, and c
            Console.WriteLine("Enter the values of a, b, and c of your equation ax ^ 2 + bx + c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            // calculate the roots
            if (b * b - 4 * a * c > 0)
            {
                double rOne = (-1 * b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
                double rTwo = (-1 * b - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);

                Console.WriteLine("First real root is: " + rOne);
                Console.WriteLine("Second real root is: " + rTwo);
            }
            else if (b * b - 4 * a * c == 0) // only one real root
            {
                double root = (-1 * b) / (2 * a);
                Console.WriteLine("Only one real root, and value is: " + root);
            }
            else
            {
                Console.WriteLine("No real root values.");
            }
        }
    }
}
