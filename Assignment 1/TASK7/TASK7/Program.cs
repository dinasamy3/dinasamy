
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number;

        while(!int.TryParse(Console.ReadLine(), out number))
       {
             Console.WriteLine("Invalid input. Please enter a valid integer.");
      }           

       Console.WriteLine($"Multiplication table for {number}:");

       
        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"{number * i} ");
        }

        Console.WriteLine();
    }
}
