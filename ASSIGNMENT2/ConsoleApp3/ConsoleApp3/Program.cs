using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello";
        int position = 1;  
        char newChar = 'a';

        string modifiedString = ChangeChar(originalString, position, newChar);

        Console.WriteLine($"Original string: {originalString}");
        Console.WriteLine($"Modified string: {modifiedString}");
    }
    static string ChangeChar(string str, int position, char newChar)
    {
        if (position < 0 || position >= str.Length)
        {
            throw new ArgumentOutOfRangeException("position", "Position is out of range.");
        }

        char[] charArray = str.ToCharArray();
        charArray[position] = newChar;

        return new string(charArray);
    }
}
