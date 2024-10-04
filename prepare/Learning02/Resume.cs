public class Resume
{
    // attributes
    public string _name;
    public List<Job> _jobs = new();

    // methods/behaviors

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}