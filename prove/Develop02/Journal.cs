using System.Collections.Generic; 
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
    public void SaveToFile()
    {

    }
    public void LoadFile()
    {

    }
}
