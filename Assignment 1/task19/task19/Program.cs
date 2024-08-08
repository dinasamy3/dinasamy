using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the size of the matrix (n): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i == j ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}
