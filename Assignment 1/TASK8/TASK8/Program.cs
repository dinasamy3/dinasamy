

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;

        while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer greater than or equal to 1.");
        }

        Console.WriteLine($"Even numbers between 1 and {number}:");
        for (int i = 2; i <= number; i += 2)
        {
            Console.Write($"{i} ");
        }

       
    }
}
