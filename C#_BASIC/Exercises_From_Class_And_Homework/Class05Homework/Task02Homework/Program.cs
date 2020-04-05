using System;

namespace Task02Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pet = new Dog();

            Console.WriteLine("Please choose the name of the dog!!!");
            pet.Name = Console.ReadLine();

            Console.WriteLine($"Please input what is {pet.Name}'s race");
            pet.Race = Console.ReadLine();

            Console.WriteLine($"Please input what color is {pet.Name}");
            pet.Color = Console.ReadLine();

            Console.WriteLine($"Please choose what you want {pet.Name} ");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. ChasingTail");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    pet.Eat();
                    break;

                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.ChasingTail();
                    break;
                default:
                    Console.WriteLine("Exiting...");
                    break;
            }

            Console.ReadLine();
        }
    }

    public class Dog
    {
        public string Name;
        public string Race;
        public string Color;

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} , a {Color} {Race} is now eating!!!!!");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} , a {Color} {Race} is now playing!!!!!");
        }

        public void ChasingTail()
        {
            Console.WriteLine($"The dog {Name} , a {Color} {Race} is now chasing it's tail!!!!!");
        }
    }

}
