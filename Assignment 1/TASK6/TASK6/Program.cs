


using System;

class Program
{
    static void Main()
    {
        try
        {

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1)
            {
                Console.WriteLine("Please enter a positive integer : ");
            }

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);

            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
