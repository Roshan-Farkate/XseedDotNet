using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        int number;
        string greeting = GetGreeting(name);
        Console.WriteLine(greeting);
    }

    static string GetGreeting(string name)
    {
        return $"Hello, {name}! Welcome to the world of C#!";
    }
}
