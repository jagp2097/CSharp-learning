using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String name;
            int age;

            Console.Write("Write your name: ");
            name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            imprimirNombre(name, age);

        }

        static void imprimirNombre(String name, int age = 0) 
        {
            Console.WriteLine($"Hi {name}, your age is {age}...");
        }

    }
}
