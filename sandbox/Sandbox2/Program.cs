namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        List<double> x;
        x = [24, 25, 26.27];

        Console.WriteLine("Howdy, Potato World!");

        foreach (double number in x)
        {
            Console.WriteLine(number);
        }
    }
}
