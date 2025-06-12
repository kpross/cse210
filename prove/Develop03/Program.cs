using System;

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------

class Program
{
    static void Main(string[] args)
    {
        // --- 1. Store a scripture, including both the reference and the text. ---
        // Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".

        // Example: John 3:16 (single verse)
        Reference john3_16Reference = new Reference("John", 3, 16);
        string john3_16Text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture john3_16Scripture = new Scripture(john3_16Reference, john3_16Text);

        // Example: Proverbs 3:5-6 (multiple verses)
        Reference proverbs3_5_6Reference = new Reference("Proverbs", 3, 5, 6);
        string proverbs3_5_6Text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture proverbs3_5_6Scripture = new Scripture(proverbs3_5_6Reference, proverbs3_5_6Text);

        // Let's choose which scripture to use for this run.
        Scripture currentScripture = proverbs3_5_6Scripture; // You can switch this to proverbs3_5_6Scripture to test multi-verse

        // --- Main Application Loop ---
        string userInput = "run";
        do
        {
            // --- Clear the console screen and display the complete scripture ---
            Console.Clear(); // Clears the console screen

            // Display the scripture reference and the rendered text (with hidden words).
            // Uses GetDisplayText() from the Reference class
            Console.WriteLine(currentScripture.Reference.GetDisplayText());
            // Uses GetRenderedText() from the Scripture class
            Console.WriteLine(currentScripture.GetRenderedText());
            Console.WriteLine(); // Add an empty line for spacing

            // --- When all words in the scripture are hidden, ends the program. ---
            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. You've memorized the scripture!");
                break; // Exit the loop
            }

            // --- Prompt the user to press the enter key or type quit. ---
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            userInput = Console.ReadLine(); // Reads user input

            // --- If the user presses the enter key (without typing quit),
            //     the program should hide a few random words in the scripture,
            //     clear the console screen, and display the scripture again. ---
            if (string.IsNullOrEmpty(userInput)) // Checks if the user just pressed Enter
            {
                // This calls the HideRandomWords method from the Scripture class.
                // Our implementation of HideRandomWords already handles selecting
                // from *unhidden* words, which is the stretch challenge!
                currentScripture.HideRandomWords(3); // Hide 3 random words each time
            }
            // The loop continues as long as the user doesn't type "quit".
            // The .ToLower() makes the comparison case-insensitive.
        } while (userInput.ToLower() != "quit");

        // When the loop ends (either by quitting or all words hidden)
        Console.WriteLine("\nGoodbye!");
    }
}