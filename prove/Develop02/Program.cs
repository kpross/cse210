using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        DateTime theCurrentDate = DateTime.Today;
        string dateText = theCurrentDate.ToShortDateString();

        Entry entry1 = new Entry();
        entry1._date = dateText;
        entry1._entry = "Today";

        Entry entry2 = new Entry();

        entry2._entry = "Tomorrow";

        Entry entry3 = new Entry();
        entry3._entry = "the next day";

        Journal myJournal = new Journal();
        myJournal._owner = "John Smith";

        myJournal._entries.Add(entry1);
        myJournal._entries.Add(entry2);
        myJournal._entries.Add(entry3);

        myJournal.Display();
    }
}