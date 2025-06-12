using System;
using System.Collections.Generic; // Required for List<T>
using System.IO;                  // Required for File I/O (StreamWriter, StreamReader)

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


// Represents a journal containing a list of entries.
public class Journal
{
    // Member variable to store the owner's name for the journal.
    public string _owner;
    // A list to hold all the Entry objects in this journal.
    public List<Entry> _entries = new List<Entry>();

    // Displays the journal's owner and then iterates through and displays each entry.
    public void Display()
    {
        Console.WriteLine($"\n--- {_owner}'s Journal ---");
        // Check if there are any entries to display.
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
        }
        else
        {
            // Iterate through each entry in the _entries list and call its Display method.
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        Console.WriteLine("------------------------\n");
    }

    // Adds a new Entry object to the journal's list of entries.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Saves the current journal entries to a specified file.
    public void SaveToFile(string filename)
    {
        try
        {
            // Create a new StreamWriter to write to the specified file.
            // 'true' in StreamWriter constructor appends to the file, but we want to overwrite,
            // so we'll just create a new one each time implicitly.
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Optionally, save the owner's name as the first line (though not strictly required by problem)
                // outputFile.WriteLine(_owner); 

                // Iterate through each entry in the list.
                foreach (Entry entry in _entries)
                {
                    // Write the savable string representation of each entry to the file.
                    outputFile.WriteLine(entry.ToSavableString());
                }
            }
            Console.WriteLine($"Journal saved successfully to '{filename}'.");
        }
        catch (Exception ex)
        {
            // Catch and display any errors that occur during file saving.
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Loads journal entries from a specified file, replacing current entries.
    public void LoadFromFile(string filename)
    {
        try
        {
            // Clear any existing entries in the journal before loading new ones.
            _entries.Clear();

            // Create a new StreamReader to read from the specified file.
            using (StreamReader inputFile = new StreamReader(filename))
            {
                string line;
                // Read lines from the file until the end.
                while ((line = inputFile.ReadLine()) != null)
                {
                    // Split each line by the pipe '|' character.
                    string[] parts = line.Split('|');
                    // Ensure the line has at least two parts (date and entry text).
                    if (parts.Length >= 2)
                    {
                        string date = parts[0];
                        // Reconstruct the full entry text in case it contained the separator character.
                        string entryText = string.Join("|", parts, 1, parts.Length - 1);

                        // Create a new Entry object with the parsed data.
                        Entry loadedEntry = new Entry(date, entryText);
                        // Add the loaded entry to the journal's list.
                        _entries.Add(loadedEntry);
                    }
                }
            }
            Console.WriteLine($"Journal loaded successfully from '{filename}'.");
        }
        catch (FileNotFoundException)
        {
            // Specific catch for when the file doesn't exist.
            Console.WriteLine($"Error: File '{filename}' not found.");
        }
        catch (Exception ex)
        {
            // Generic catch for any other errors during file loading.
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
