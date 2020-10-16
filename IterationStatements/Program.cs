using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0

            int i = 0;

            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                i++;
                // Then add your variable to "numbers"
                numbers.Add( i/* variable name goes here */);
            } while (i < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            int j = 0;
            while(j < 200)
            {
                j++;
                
                // Increment your variable by 1
                // Then add your variable to "numbers"
                numbers.Add(j);
                
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach(var number in numbers ) 
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int k = 199; k <= numbers.Count -1; k--)
            {
                if(k >= 0)
                {
                    Console.WriteLine(numbers[k]);
                }
                

                // Write to the console "numbers" at index i
            }
        }
    }
}
