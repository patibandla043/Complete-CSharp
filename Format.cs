
using System;

class Format
{
    static void Main()
    {
        Console.Write("Enter an integer as a string: ");
        string input = Console.ReadLine();

        try
        {
            int num = Convert.ToInt32(input);
            Console.WriteLine("Parsed integer: " + num);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: The input is not a valid integer.");
        }
    }
}
