using System;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01_RealCalculator

            Console.WriteLine("Please enter first number");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What arithmetic operation would you like to use : + , - , * , / ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Divsion");
            Console.WriteLine("4.Multiplication");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("The result of the addition of the numbers " + firstNum + " and " + secondNum + " is " + (firstNum + secondNum));
                    break;
                case 2:
                    Console.WriteLine(" The result of the subtraction of the numbers " + firstNum + " and " + secondNum + " is " + (firstNum - secondNum));
                    break;
                case 3:
                    Console.WriteLine(" The result of the devision of the numbers " + firstNum + " and " + secondNum + " is " + (firstNum / secondNum));
                    break;
                case 4:
                    Console.WriteLine(" The result of the multiplication of  the  numbers " + firstNum + " and " + secondNum + " is " + (firstNum * secondNum));
                    break;
            }

            Console.ReadLine();
            #endregion
        }
    }
}
