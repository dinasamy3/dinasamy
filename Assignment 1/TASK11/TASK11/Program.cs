

class task11
{
    static void Main()
    {
        Console.Write("Enter the month number (1-12): ");
        int monthNum;

        while (!int.TryParse(Console.ReadLine(), out monthNum) || monthNum < 1 || monthNum > 12)
        {
            Console.WriteLine("Invalid input. Please enter a valid month number between 1 and 12.");
        }

        int daysInMonth = 0;

        switch (monthNum)
        {
            case 1: 
            case 3: 
            case 5: 
            case 7: 
            case 8: 
            case 10: 
            case 12: 
                daysInMonth = 31;
                break;
            case 4: 
            case 6: 
            case 9: 
            case 11: 
                daysInMonth = 30;
                break;
            case 2: 
                
                daysInMonth = 28;
                break;
        }

        Console.WriteLine($"Days in Month: {daysInMonth}");
    }
}
