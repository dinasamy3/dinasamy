
class Program
{
    static void Main()
    {
        Console.Write("Enter a number to convert: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The Binary of {number} is {DecimalToBinary(number)}.");
    }

    static string DecimalToBinary(int number)
    {
        string binary = "";
        do
        {
            binary = (number % 2) + binary;
            number /= 2;
        } while (number > 0);

        return binary;
    }
}
