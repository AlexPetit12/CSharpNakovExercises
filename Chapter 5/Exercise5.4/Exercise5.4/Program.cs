using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5._4
{
    class Program
    {
        // Sort 3 real numbers in descending order. Use nested if statements.
        static void Main(string[] args)
        {
            // ask the user three real numbers
            Console.WriteLine("Enter three real numbers: ");

            float numOne = float.Parse(Console.ReadLine());
            float numTwo = float.Parse(Console.ReadLine());
            float numThree = float.Parse(Console.ReadLine());

            // sort the three numbers in descending order where numThree will hold the largest number,
            // numTwo the second largest number and numOne the smallest number
            if (numOne >= numTwo)
            {
                if (numTwo >= numThree)
                {
                    float temp = numOne;
                    numOne = numThree;
                    numThree = temp;
                }
                else
                { 
                    if(numThree >= numOne)
                    {
                        float temp = numTwo;
                        numTwo = numOne;
                        numOne = temp;
                    }
                    else
                    {
                        float temp = numTwo;
                        numTwo = numThree;
                        numThree = numOne;
                        numOne = temp;
                    }
                }
            }
            else
            {
                if (numOne >= numThree)
                {
                    float temp = numThree;
                    numThree = numTwo;
                    numTwo = numOne;
                    numOne = temp;
                }
                else if(numTwo >= numThree)
                { 
                    float temp = numThree;
                    numThree = numTwo;
                    numTwo = temp;
                }
            }

            // print result
            Console.WriteLine("The three real numbers in descending order is: " + numThree + " " + numTwo + " " + numOne);
        }
    }
}
