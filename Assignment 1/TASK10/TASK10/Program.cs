
class task10
{
    static void Main()
    {
        int[] marks = new int[5];
        int totalMarks = 0;

        Console.WriteLine("Enter marks of five subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative integer for the marks.");
            }
            totalMarks += marks[i];
        }

        
        double averageMarks = totalMarks / 5.0;
        double percentage = averageMarks;  

     
        Console.WriteLine($"\nTotal Marks = {totalMarks}");
        Console.WriteLine($"Average Marks = {averageMarks}");
        Console.WriteLine($"Percentage = {percentage}");
    }
}

