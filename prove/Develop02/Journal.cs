using System.Collections.Generic; 
using System.IO;

public class Journal
{
    // attributes
    public List<Entry> _entries = new();
    public string _fileName;

    // behaviors
    public void AddEntry(string date, string prompt, string entry)
    {
        Entry userEntry = new()
        {
            _date = date,
            _prompt = prompt,
            _entry = entry
        };

        _entries.Add(userEntry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new(fileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }
    public void LoadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            if (parts.Length == 3)
            {
                                
                Entry newEntry = new()
                {
                    _date = date,
                    _prompt = prompt,
                    _entry = entry
                };

                _entries.Add(newEntry);
            }

            else
            {
                Console.WriteLine("Unable to read line, skipping.");
            }
            
            }
        }
    }

