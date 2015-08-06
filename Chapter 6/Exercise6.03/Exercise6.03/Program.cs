using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise6._03
{
    class Program
    {
        // Write a program that reads from the console a series of integers and prints the smallest and largest of them.
        static void Main(string[] args)
        {
            // ask the user a series of numbers
            Console.WriteLine("Enter the quantity of numbers: ");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];

            for(int i = 0; i< N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // sort the array
            Array.Sort(numbers);

            // print results
            Console.WriteLine("The smallest number is: " + numbers[0]);
            Console.WriteLine("The highest number is: " + numbers[N - 1]);
        }
    }
}
