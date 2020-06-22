using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, favColor;
            int age, drinkingAge = 21;

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("How old are you " + name + ": ");
            age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite color: ");
            favColor = Console.ReadLine();

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), favColor);
            Console.Clear();

            Console.WriteLine("Hello " + name + " and Welcome!");

            if (age >= drinkingAge)
                Console.WriteLine("You should have a beer after work!");
            else
                Console.WriteLine("You should have a rootbeer after work!");
        }
    }
}
