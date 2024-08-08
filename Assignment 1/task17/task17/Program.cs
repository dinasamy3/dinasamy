using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter x1 y1: ");
        var point1 = Console.ReadLine().Split();
        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);

        Console.Write("Enter x2 y2: ");
        var point2 = Console.ReadLine().Split();
        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);

        Console.Write("Enter x3 y3: ");
        var point3 = Console.ReadLine().Split();
        double x3 = double.Parse(point3[0]);
        double y3 = double.Parse(point3[1]);

       
        bool collinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

        Console.WriteLine(collinear ? "The points lie on a single straight line." : "The points do not lie on a single straight line.");
    }
}
