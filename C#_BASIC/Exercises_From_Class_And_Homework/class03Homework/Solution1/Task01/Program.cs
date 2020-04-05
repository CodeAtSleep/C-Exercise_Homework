using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01-SumOfEven

            int[] intArray = new int[6];

            Console.WriteLine("Please enter first integer");
            intArray[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second integer");
            intArray[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third integer");
            intArray[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter forth integer");
            intArray[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter fifth integer");
            intArray[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter sixth integer");
            intArray[5] = int.Parse(Console.ReadLine());

            int sumOfEven = 0;
            for(int i = 0 ; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sumOfEven += intArray[i];
                    
                }
                    
            };
            Console.WriteLine(sumOfEven);
           

            #endregion




            Console.ReadLine();
        }
    }
}
