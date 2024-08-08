

class reversedint
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number;

        
        while (!int.TryParse(Console.ReadLine(), out number))
        {
           Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        char[] charArray =   number.ToString().ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        int reversedNumber;
        if (int.TryParse(reversedString, out reversedNumber))
        {
            Console.WriteLine($"Reversed integer: {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Error reversing the number.");
        }
    }
}
