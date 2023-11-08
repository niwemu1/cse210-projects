using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string answer = Console.ReadLine();

        int percent = int.Parse(answer);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 
        string sign = "";
        int number = int.Parse(answer);
        number = percent % 10;

        if (number >= 7)
        {
             sign = "+";
        }
        else if (number < 3)
        {
             sign = "-";
        }
        else
        {
              sign = "";
        }

    
        if (percent >= 91)
        {
              sign = "";
        }

    
        if (letter == "F")
        {
              sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations You passed!!");
        }
        else
        {
            Console.WriteLine("Good luck next time!!");
        }
    }
}