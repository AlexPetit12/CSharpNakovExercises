using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an if-statement that takes two integer variables and exchanges 
            // their values if the first one is greater than the second one.

            // ask the user for two values
            Console.WriteLine("Enter two values: ");
            float valueOne = float.Parse(Console.ReadLine());
            float valueTwo = float.Parse(Console.ReadLine());

            // print the larger value
            if (valueOne > valueTwo)
            {
                Console.WriteLine("The larger value is: " + valueOne);
            }
            else if (valueTwo > valueOne)
            {
                Console.WriteLine("The larger value is: " + valueTwo);
            }
            else
            {
                Console.WriteLine("You entered twice the same value!");
            }

        }
    }
}
