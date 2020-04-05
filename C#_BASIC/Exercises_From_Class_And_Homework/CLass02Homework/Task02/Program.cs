using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task02_AverageNumber

            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            Console.WriteLine("Please enter first number");
            int firstInp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondInp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number");
            int thirdInp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fourth number");
            int forthInp = int.Parse(Console.ReadLine());

            int resultOfInput = (firstInp + secondInp + thirdInp + forthInp) / 4;
            Console.WriteLine(" The average number  of the four inputed numbers  is " + resultOfInput);
            Console.ReadLine();

            #endregion
        }
    }
}
