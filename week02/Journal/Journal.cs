using System.Configuration.Assemblies;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
       
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
        string filename = Console.ReadLine();

        
    }
    public void LoadFromFile(string file)
    {
        Console.Write("Enter the file name: ");
        string filename = Console.ReadLine();
    
    }
}