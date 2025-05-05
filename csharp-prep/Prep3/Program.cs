using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -20;

        while (guess != number)
        {
            Console.Write("Guess a number between 1 and 100: \n");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > number)
            Console.Write("Lower!\n");

            else if (guess < number)
            Console.Write("Higher!\n");

            else
            Console.Write("You Got It!!!\n");
        }
    }
}