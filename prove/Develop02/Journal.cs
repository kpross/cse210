using System;

public class Journal
{
    public string _owner;
    public List<Entry> _entries = new List<Entry>();
     public void Display()
    {
        Console.WriteLine($"{_owner}'s Journal");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}