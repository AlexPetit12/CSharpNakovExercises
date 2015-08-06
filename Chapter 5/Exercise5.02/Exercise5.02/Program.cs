using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that shows the sign (+ or -) of the product of three real numbers, 
            // without calculating it. Use a sequence of if operators.

            // ask the user three real numbers
            Console.WriteLine("Enter three real numbers: ");

            float valueOne = float.Parse(Console.ReadLine());
            float valueTwo = float.Parse(Console.ReadLine());
            float valueThree = float.Parse(Console.ReadLine());

            // print the sign of the product
            if (negativeNumbersCount(valueOne, valueTwo, valueThree) % 2 == 0 && negativeNumbersCount(valueOne, valueTwo, valueThree) != -1)
            {
                Console.WriteLine("The sign of the product is: +");
            }
            else if (negativeNumbersCount(valueOne, valueTwo, valueThree) % 2 != 0 && negativeNumbersCount(valueOne, valueTwo, valueThree) != -1)
            {
                Console.WriteLine("The sign of the product is: -");
            }
            else 
            {
                Console.WriteLine("The product is 0.");
            }

        }

        static public int negativeNumbersCount(float x, float y, float z)
        {
            // check whether there is a 0
            if (x == 0 || y == 0 || z == 0)
            {
                return -1;
            }

            // return quantity of negative numbers
            int count = 0;

            if (x < 0)
            {
                count++;
            }

            if (y < 0)
            {
                count++;
            }

            if (z < 0)
            {
                count++;
            }

            return count;
        }
    }
}
