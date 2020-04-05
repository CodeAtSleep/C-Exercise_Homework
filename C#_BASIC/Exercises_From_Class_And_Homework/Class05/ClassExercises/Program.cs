using System;

namespace ClassExercises
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void getHumanInfo()
        {
            Console.WriteLine($"I am {FirstName} {LastName} , {Age} years old.");
        }

    }


        class Program
    {
        static void Main(string[] args)
        {
            Human Deni = new Human();

            Console.WriteLine("Enter firstname");
            Deni.FirstName = Console.ReadLine();

            Console.WriteLine("Enter lastname");
            Deni.LastName = Console.ReadLine();

            Console.WriteLine("Enter age");
            Deni.Age = int.Parse(Console.ReadLine());


            Deni.getHumanInfo();

            Console.ReadLine();
        }
    }
}
