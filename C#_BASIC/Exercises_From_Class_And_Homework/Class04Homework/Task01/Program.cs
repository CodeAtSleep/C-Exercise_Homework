using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {   
            Substring();
            Console.ReadLine();
        }


        static void Substring()
        {
            string hiSedc = "Hello from SEDC Codecademy v8.0";
            Console.WriteLine(hiSedc);

            Console.WriteLine($"Please enter a number within range from 1 to {hiSedc.Length}");

            int userInput = int.Parse(Console.ReadLine());
            //Console.WriteLine(userInput);

            if(userInput > hiSedc.Length || userInput < 1 )
            {
                Console.WriteLine($"Wrong input . Please enter a number within range of 1 to {hiSedc.Length}");
            }   else
            {
                char[] karakter = hiSedc.ToCharArray();
                Console.WriteLine($"The character  \"{karakter[userInput-1]}\" is at {userInput}th place");

                // string.substring method retrieves a substring from a string instance in C#
                //we use the substring method here and pass it starting index 0 to the length of the substring userInput to get the first  char substring from the string.  .
                string substr = hiSedc.Substring(0, userInput);
                Console.WriteLine($"The {userInput} characters are \"{substr}\" and the length  of this new string is {substr.Length} ");


            }



        }

    }
}
