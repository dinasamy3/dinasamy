using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        Console.WriteLine($"The sum of all elements in the array is: {sum}");
    }
}
