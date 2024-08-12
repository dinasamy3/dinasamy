
class Program
{
    static void Main()
    {
  
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }

    static long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("number", "Factorial is not defined for negative numbers.");
        }

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
