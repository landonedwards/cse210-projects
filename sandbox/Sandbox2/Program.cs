﻿namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        List<double> x = new();
        // x.Add(24.5);

        Console.WriteLine("Howdy, Potato World!");

        // gather data to fill up a list

        double input = -1;
        while(input != 0)
        {
            Console.Write("Enter something: ");
            string input_string = Console.ReadLine();
            input = double.Parse(input_string);
            x.Add(input);
        }

        foreach (double number in x)
        {
            Console.WriteLine(number);
        }
    }
}
