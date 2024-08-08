



class Program
{
    static void Main()
    {
        Console.Write("Enter the base number: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the base number.");
        }
        Console.Write("Enter the exponent: ");
        int exponent;
        while (!int.TryParse(Console.ReadLine(), out exponent))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the exponent.");
        }
        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= num;
        }

        Console.WriteLine($"{num} to the power of {exponent} is {result}");
    }
}
