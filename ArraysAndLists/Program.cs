using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();




            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int dig in digits)
            {
                if(dig % 2 == 0)
                {
                    evens.Add(dig);
                }
                else
                {
                    odds.Add(dig);
                }
            }




            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int dig in evens)
            {
                Console.WriteLine($"{dig} is on the evens list");
            }
            foreach (int dig in odds)
            {
                Console.WriteLine($"{dig} is a weird, I mean, odd number");
            }



        }
    }
}
