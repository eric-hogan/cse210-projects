using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        string dateAsText = currentDate.ToShortDateString();

        int selection = 0;
        
        Journal theJournal = new Journal();
        do
        {
            Console.WriteLine(@"Welcome What Would you like to do today?
            1) Write a new journal entry.
            2) Display current journal entries
            3) Open a different journal
            4) Save current entries
            5) Quit");

            Console.Write("Please enter your selection: ");
            string selectionAsText = Console.ReadLine();
            selection = int.Parse(selectionAsText);


            // New entry created.
            if (selection == 1)
            {
                Entry journalEntry = new Entry();
                journalEntry._date = dateAsText;
                PromptGenerator newPrompt = new PromptGenerator();
                journalEntry._promptText = newPrompt.GetRandomPrompt();
                Console.WriteLine(journalEntry._promptText);
                journalEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(journalEntry);

            }

            else if (selection == 2)
            {
                theJournal.DisplayAll();
            }

            else if (selection == 3)
            {
                Journal loadedJournal = new Journal();
                loadedJournal.LoadFromFile("");
            }

            else if (selection == 4)
            {
                theJournal.SaveToFile("");
            }


        } while (selection != 5);

        Console.WriteLine("Have a great day!");
    }
}