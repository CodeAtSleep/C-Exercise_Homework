using System;

namespace Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01-07

            //exercise1
            double ex1 = 2.99;
            double ex2 = 6.99;
            double exResult = ex1/ex2 ;

            Console.WriteLine(exResult);

            int intEx1 = 9;
            int intEx2 = 3;

            int intResult = intEx1/intEx2 ;
            Console.WriteLine(intResult);

            //exercise2

            string firstName = "Deni";
            string lastName = "Stojanovski";

            string fullName = firstName + " " + lastName ;

            Console.WriteLine(fullName);

            //exercise3

            string nine = "9";
            string three = "3";

            string nineThreeResult = nine + three ; //xD horrible naming
            Console.WriteLine(nineThreeResult);


            //exercise4
            //You have n credits on your mobile bill. One SMS costs m credits. How many SMS messages you can send?

            int credit = 102;
            int smsCost = 5;

            int possibleMsnSent = credit/smsCost ;
            Console.WriteLine("You can send " + possibleMsnSent + " messages");


            //exercise5
            //Solve the following problem. On one tree there are 12 branches with  n apples on them. One basket can hold m apples. If a user enters number of trees find out how many baskets does it take to collect all the apples from the trees?

            int numberOfApples = 8;
            int basketCapacity = 5;
            int treeBranches = 12;

            Console.WriteLine("Please enter a number of trees");
            string userInputTrees = Console.ReadLine();
            int numberOfTrees = int.Parse(userInputTrees);

            int totalApples = numberOfApples * treeBranches * numberOfTrees;

            int problemResult = 0;
            if (totalApples % basketCapacity == 0)
            {
                problemResult = totalApples / basketCapacity;
            }   else
            {
                problemResult = (totalApples / basketCapacity) + 1;
            }

            Console.WriteLine("You will need " + problemResult + " baskets for the " + totalApples + " apples");


            //exercise6
            //Create two variables and initialize them with a keyboard input
            //Write code that can test which number is larger
            //Write code that can test the numbers whether they are even or odd
            //Write the larger number from the two in the console
            //After that write if the number is even or odd

            Console.WriteLine("Please enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNumber = int.Parse(Console.ReadLine()) ;

            //larger check

            int larger;
            if (firstNumber > secondNumber)
            {
                larger = firstNumber;
                Console.WriteLine("The first number " + larger + " is larger than the second number " + secondNumber);
            } else if (secondNumber > firstNumber)
            {
                larger = secondNumber;
                Console.WriteLine("The second number inputed by the user " + larger + " is larger than the first number " + firstNumber);
            } else
            {
                larger = firstNumber;
                Console.WriteLine("the numbers are of equal value");
            }

            //exercise7
            //Ask the user to enter a number from 1 to 3
            //If the user enters “1” write “You got a new car!”
            //If the user enters “2” write “You got a new plane!”
            //If the user enter “3” write “You got a new bike!”
            //If the user enters a wrong number or character write an error message in the console

            Console.WriteLine("Please enter a number between 1 and 3");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Wrong number ! Please enter a valid number ! ");
                    break;
            }


            #endregion





            Console.ReadLine();
        }
    }
}
