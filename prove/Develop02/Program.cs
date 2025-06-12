using System;
using System.Collections.Generic; // Required for List<T>

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


// The main program class that orchestrates the Journal application.
class Program
{
    // The main entry point of the application.
    static void Main(string[] args)
    {
        // Display a welcome message to the user.
        Console.WriteLine("Welcome to the Journal Program!");

        // Create a new instance of the Journal.
        Journal myJournal = new Journal();
        // Set the owner of the journal (can be changed or prompted from user).
        myJournal._owner = "My Daily Journal";

        // Create an instance of the PromptGenerator to get random prompts.
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = ""; // Variable to store user's menu choice

        // Loop until the user chooses to quit.
        while (choice != "5")
        {
            // Display the main menu options to the user.
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // Read the user's choice from the console.
            choice = Console.ReadLine();

            // Use a switch statement to handle different menu choices.
            switch (choice)
            {
                case "1": // Write a new entry
                    // Get a random prompt from the generator.
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    // Get the user's response to the prompt.
                    string userResponse = Console.ReadLine();

                    // Get the current date.
                    DateTime theCurrentDate = DateTime.Today;
                    string dateText = theCurrentDate.ToShortDateString();

                    // Create a new Entry object with the date and the combined prompt and response.
                    // Storing prompt within the entry text for easy display later.
                    Entry newEntry = new Entry(dateText, $"{randomPrompt}\n{userResponse}");
                    // Add the new entry to the journal.
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2": // Display the journal
                    // Call the Display method of the Journal object to show all entries.
                    myJournal.Display();
                    break;

                case "3": // Load the journal from a file
                    Console.Write("What is the filename to load? ");
                    string loadFilename = Console.ReadLine();
                    // Call the LoadFromFile method of the Journal.
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case "4": // Save the journal to a file
                    Console.Write("What is the filename to save? ");
                    string saveFilename = Console.ReadLine();
                    // Call the SaveToFile method of the Journal.
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "5": // Quit the program
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;

                default: // Handle invalid choices
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
