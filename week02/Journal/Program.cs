using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        string dateAsText = currentDate.ToShortDateString();

        Journal theJournal = new Journal();

        // New entry created.
        Entry journalEntry = new Entry();
        journalEntry._date = dateAsText;
        PromptGenerator newPrompt = new PromptGenerator();
        journalEntry._promptText = newPrompt.GetRandomPrompt();
        Console.WriteLine(journalEntry._promptText);
        journalEntry._entryText = Console.ReadLine();
        
        // Entry displayed
        journalEntry.Display();


        theJournal.AddEntry(journalEntry);

    }
}