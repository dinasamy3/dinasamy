
class Program
{
    static void Main()
    {
      
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        int num4 = int.Parse(Console.ReadLine());

   
        var result = PerformOperations(num1, num2, num3, num4);
        Console.WriteLine($"Sum of first two numbers: {result.sum1}");
        Console.WriteLine($"Difference of first two numbers: {result.subtraction1}");
    }

    static (int sum1, int subtraction1) PerformOperations(int num1, int num2, int num3, int num4)
    {
        int sum1 = num1 + num2;
        int subtraction1 = num1 - num2;
      
        return (sum1, subtraction1);
    }
}
