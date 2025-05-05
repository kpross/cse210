using System;

class Program
{
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int num = PromptUserNumber();

        int sn = SquareNumber(num);

        DisplayResult(name, sn);
    }
}