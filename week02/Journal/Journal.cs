using System.Configuration.Assemblies;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll(){

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
            }
            Console.WriteLine("Journal has been saved");
        }  

        
    }
    public void LoadFromFile(string file)
    {
        Console.Write("Enter the file name: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Console.WriteLine(parts[0]);
            Console.WriteLine(parts[1]);
            Console.WriteLine(parts[2]);


        } 

    
    }
}