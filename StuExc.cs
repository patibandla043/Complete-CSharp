using System;

class StuExc
{
    static void Main()
    {
        string name = null;
        int score=0;

        try
        {
            Console.WriteLine("Enter name value");
            name = Console.ReadLine();

            if (name == null)
            {
                throw new ArgumentNullException("name", "Name cannot be null.");
            }

            Console.WriteLine("Enter score value");
            score = Convert.ToInt32(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException("score", "Score must be between 0 and 100.");
            }

            Console.WriteLine("Enter the student's name: " + name);
            Console.WriteLine("Enter the student's score: " + score);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.ToString());
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.ToString());
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.ToString());
        }

        if (name != null && score >= 0 && score <= 100)
        {
            Console.WriteLine("The score has been successfully recorded.");
        }
    }
}
