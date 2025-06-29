using System;

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


class Program
{
    static void Main(string[] args)
    {


       
        Reference john3_16Reference = new Reference("John", 3, 16);
        string john3_16Text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture john3_16Scripture = new Scripture(john3_16Reference, john3_16Text);


        Reference proverbs3_5_6Reference = new Reference("Proverbs", 3, 5, 6);
        string proverbs3_5_6Text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture proverbs3_5_6Scripture = new Scripture(proverbs3_5_6Reference, proverbs3_5_6Text);
        Scripture currentScripture = proverbs3_5_6Scripture; 


        string input = "";

        while (input.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();

           
            Console.WriteLine(currentScripture.Reference.GetDisplayText());
            Console.WriteLine(currentScripture.GetHiddenText());
            Console.WriteLine(); 

            
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            input = Console.ReadLine(); 
            
            if (input == "")
            {
                currentScripture.HideRandomWords(5);
            }
        }

        if (currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.Reference.GetDisplayText());
            Console.WriteLine(currentScripture.GetHiddenText());
            Console.WriteLine();
            Console.WriteLine("All words are hidden. You've memorized the scripture!");
        }
        else if (input.ToLower() == "quit")
        {
            Console.WriteLine("Exiting program. Goodbye!");
        }

                Console.WriteLine("\nGoodbye!");
            }
}