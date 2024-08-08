


using System;

class Program
{
    static void Main()
    {
        try
        {

            Console.Write("Enter a character: ");
            char inputChar = char.Parse(Console.ReadLine());

            char lowerChar = char.ToLower(inputChar);

            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid character.");
        }
    }
}
