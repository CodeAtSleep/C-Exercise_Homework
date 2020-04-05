using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StudentGroup exercise

            string[] studentG1 = new string[]
            {
                "Zdravko", "Petko", "Stanko", "Branko", "Trajko"
            };

            string[] studentG2 = new string[]
            {
                "Deni","Dejan","Kristina","Simon","Ivan"
            };

            Console.WriteLine("Please enter 1 or 2 to see student group");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                foreach (string str in studentG1)
                {
                    Console.WriteLine(str);
                }
            } 
            if(input == 2)
            {

                foreach (string str in studentG2)
                {
                    Console.WriteLine(str);
                }
            }


            #endregion


            Console.ReadLine();
        }
    }
}
