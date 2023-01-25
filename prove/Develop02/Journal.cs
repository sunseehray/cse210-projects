using System;
using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void Write()
    {
        Entry record = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        DateTime currentDate = DateTime.Now;
        record._currentDate = currentDate.ToString();
        record._prompt = prompt.GeneratePrompt();
        Console.WriteLine($"{record._prompt}");
        record._response = Console.ReadLine();

        _journal.Add(record);
        
    }

    public void DisplayJournal()
    {
        Console.WriteLine();
        foreach (Entry n in _journal)
        {
            n.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry n in _journal)
            {
                outputFile.WriteLine($"{n._currentDate}|{n._prompt}|{n._response}");
            }
        }
    }

    public void LoadJournal()
    {
        _journal.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry record = new Entry();
            string[] parts = line.Split("|");
            string journalDate = parts[0];
            string journalPrompt = parts[1];
            string journalResponse = parts[2];

            record._currentDate = journalDate;
            record._prompt = journalPrompt;
            record._response = journalResponse;

            _journal.Add(record);
        }

        

    }
}