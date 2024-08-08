
using System;

class Program
{
    static void Main()
    {
        try
        {
           
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
