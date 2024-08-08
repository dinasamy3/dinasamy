using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the time taken to complete the task (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        Console.WriteLine($"Efficiency Level: {DetermineEfficiency(timeTaken)}");
    }

    static string DetermineEfficiency(double time)
    {
        if (time >= 2 && time <= 3) return "Highly efficient";
        if (time > 3 && time <= 4) return "Increase your speed";
        if (time > 4 && time <= 5) return "Provide training to enhance speed";
        if (time > 5) return "Required to leave the company";
        return "Invalid time input";
    }
}
