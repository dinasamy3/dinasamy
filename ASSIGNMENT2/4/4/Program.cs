
class Program
{
    static void Main()
    {
        
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = SumOfDigits(number);

        Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
    }
    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
