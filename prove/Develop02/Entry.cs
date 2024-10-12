using System.ComponentModel.DataAnnotations;

public class Entry
{
    // attributes
    public string _date;
    public string _prompt;
    public string _entry;

    // behaviors
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}: \n{_entry}\n");
    }
}