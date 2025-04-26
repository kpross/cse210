using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string gps = Console.ReadLine();
        int gp = int.Parse(gps);

        string lg = "unknown";

        if (gp >= 90)
            {
                lg = "A";
            }
        else if (gp >= 80)
            {
                lg = "B";
            }
            else if (gp >= 70)
            {
                lg = "C";
            }
            else if (gp >= 60)
            {
                lg = "D";
            }
            else if (gp <= 50)
            {
                lg = "F";
            }
        Console.WriteLine($"Your letter grade is is {lg}!");
        if (gp >= 70)
        {
            Console.WriteLine("Congrats, You Passed!!!");
        }
        else
        {
            Console.WriteLine("Sorry, Try again next time");
        }
    }
}