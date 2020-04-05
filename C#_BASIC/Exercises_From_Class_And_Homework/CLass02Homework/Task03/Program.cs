using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SwapNumbers

            //task03
            //Create new console application “SwapNumbers”. 
            //Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.

            Console.WriteLine("Please input a first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input a second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int tempHold = firstNumber ;
            firstNumber = secondNumber;
            secondNumber = tempHold;

            Console.WriteLine("Th values of the variable after swaping : ");
            Console.WriteLine("The first number is : " + firstNumber);
            Console.WriteLine("The second number is : " + secondNumber);

            //we use a temporary variable 


            Console.ReadLine();
            #endregion

        }
    }
}
