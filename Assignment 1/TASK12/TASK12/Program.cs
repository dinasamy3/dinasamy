
class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter the first number: ");
        double num1;

      
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.Write("Enter the second number: ");
        double num2;

        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
  

        int operation;

        while (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 4)
        {
            Console.WriteLine("Invalid input. Please enter a valid operation number (1-4).");
        }

        double result = 0;
        bool validOperation = true;
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
        }  
    }
}
