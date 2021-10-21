using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a method that will print to the console all numbers 1000 through -1000.
            for (var i = 1000; i >= -1000 && i <= 1000; i--)
            {
                Console.WriteLine(i);
            }

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            int i = 1;
            for (i = 1; i % 3 == 0 && i < 1000; i++)
            {
                Console.WriteLine(i);
                i++;
            }

            //Write a method to accept two integers as parameters and check whether they are equal or not.

            //Write a method to check whether a given number is even or odd.

            //Write a method to check whether a given number is positive or negative.

            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: use Parse()... or the safer TryParse() for an extra challenge!!

            //Write a method to check if an integer(from the user) is in the range -10 to 10.

            //Write a method to display the multiplication table(from 1 to 12) of a given integer.










        }
    }
}
