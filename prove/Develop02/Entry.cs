using System.ComponentModel.DataAnnotations;

public class Entry
{
    // attributes
    public int _date;
    public string _prompt;
    public string _entry;

    // behaviors
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}: \n {_entry}.");
    }
}