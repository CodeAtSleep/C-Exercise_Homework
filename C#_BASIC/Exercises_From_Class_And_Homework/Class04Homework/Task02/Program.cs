using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a - or a +");
            string userChoice = Console.ReadLine();

            if (userChoice == "-" || userChoice == "+")
            {
                Console.WriteLine("Enter first number");
                int userInput1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int userInput2 = int.Parse(Console.ReadLine());

                if (userChoice == "-")
                {
                    Console.WriteLine(substractionOfInput(userInput1, userInput2));
                    Console.ReadLine();
                }
                else if(userChoice ==  "+")
                {
                    Console.WriteLine(sumOfInput(userInput1,userInput2));
                    Console.ReadLine();
                }

            }
                      
        }


        static string sumOfInput(double input1,double input2)
        {
            double sum = input1 + input2;
            return $"The result of the sum of {input1} and {input2} is {sum}";
        }

        static string substractionOfInput(double input1, double input2)
        {
            double substraction = input1 - input2;
            return $"The result of the substraction of {input1} and {input2} is {substraction}";
        }

    }
}
