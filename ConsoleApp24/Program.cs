using System;

namespace ConsoleApp24
{
    class Program
    {
        class Animal
        {
            public string kind = "DOG";
            public string name = "BOBIK";
            public int age = 4;
            public int weight = 12;

            public void PrintInfo()
            {
                Console.WriteLine($"Kind: {kind}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine($"Kind: {animal.kind}");
            Console.WriteLine($"Name: {animal.name}");
            Console.WriteLine($"Age: {animal.age} years");
            Console.WriteLine($"Weight: {animal.weight} kg");
        }
    }
}