
class Program
{
    static void Main()
    {
        Console.Write("Input starting number : ");
        int startnum = int.Parse(Console.ReadLine());

        Console.Write("Input ending number : ");
        int endnum = int.Parse(Console.ReadLine());

        Console.WriteLine($"The prime numbers between {startnum} and {endnum} are:");

        for (int number = startnum; number <= endnum; number++)
        {
            if (IsPrime(number))
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine(); 
    }
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true; 
        if (number % 2 == 0) return false; 

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
