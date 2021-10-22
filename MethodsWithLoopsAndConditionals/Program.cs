using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        static void PrintToOneThousandPlusMinus()
        {
            for (var i = 1000; i >= -1000 && i <= 1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintByThrees()
        {
            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        static void AreTwoNumbersEqual()
        {
            Console.WriteLine("Lets see if two numbers are equal");
            Console.WriteLine("What is your first number?");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you, What is your second number?");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have chosen {firstNumber} and {secondNumber}.");
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The Numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }

        }

        static void EvenOrOdd()
        {
            Console.WriteLine("This will check to see if your number input is an ODD or EVEN number.");
            Console.WriteLine("Please enter your number.");
            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is an ODD number.");
            }
                
        }


        static void PositiveOrNegativeNumber(double input)
        {
            if (input >=  0)
            {
                Console.WriteLine($"{input} is a POSITIVE number.");
            }
            else
            {
                Console.WriteLine($"{input} is a NEGATIVE number.");
            }
        }

        static void EligibleToVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"You are {age} and are eligible to vote.");
            }
            else
            {
                Console.WriteLine($"You are {age} and are too young to vote.");
            }
        }



        static void IntergerRange()
        {
            Console.WriteLine($"Please enter a number, it can be signed positive or negative.");
            int x = int.Parse(Console.ReadLine());
            if (x >= -10 && x <= 10)
            {
                Console.WriteLine($"The number {x} is within the given range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"The number {x} is NOT within the given range of -10 to 10.");
            }
        }


        static void MultiplicationTableOneToTwelve() 
        {
            Console.WriteLine($"Input a number and we will multiply it from 1 through 12.");
            int x = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 12; i++)
            {
                
                Console.WriteLine(x * i);

            }
        }

        static void Main(string[] args)
        {

            //Write a method that will print to the console all numbers 1000 through -1000.

            PrintToOneThousandPlusMinus();

            Console.ReadKey();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.

            PrintByThrees();

            Console.ReadKey();

            //Write a method to accept two integers as parameters and check whether they are equal or not.

            AreTwoNumbersEqual();

            Console.ReadKey();

            //Write a method to check whether a given number is even or odd.

            EvenOrOdd();

            Console.ReadKey();

            //Write a method to check whether a given number is positive or negative.

            PositiveOrNegativeNumber(-34);

            Console.ReadKey();

            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: use Parse()... or the safer TryParse() for an extra challenge!!

            EligibleToVote(25);

            Console.ReadKey();


            //Write a method to check if an integer(from the user) is in the range -10 to 10.

            IntergerRange();

            Console.ReadKey();

            //Write a method to display the multiplication table(from 1 to 12) of a given integer.

            MultiplicationTableOneToTwelve();

            Console.ReadKey();










        }
    }
}
