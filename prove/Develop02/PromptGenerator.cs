using System;
using System.Collections.Generic; // Required for List<T>

// This class is responsible for generating random journal prompts.
public class PromptGenerator
{
    // A list of predefined journal prompts.
    public List<string> _prompts;
    // A Random object used to select prompts randomly.
    private Random _random;

    // Constructor for the PromptGenerator class.
    public PromptGenerator()
    {
        // Initialize the list of prompts with at least five different questions.
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was a small act of kindness I witnessed or performed today?",
            "What new thing did I learn today?",
            "What challenge did I overcome today?",
            "What am I grateful for right now?"
        };

        // Initialize the Random object.
        _random = new Random();
    }

    // Returns a random prompt from the _prompts list.
    public string GetRandomPrompt()
    {
        // Generate a random index within the bounds of the _prompts list.
        int index = _random.Next(0, _prompts.Count);
        // Return the prompt at the randomly selected index.
        return _prompts[index];
    }
}
