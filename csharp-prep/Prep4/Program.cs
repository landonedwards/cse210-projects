using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();

        int userNumber = -999999;

        do
        {
            Console.Write("Enter number: ");
            string sNumber = Console.ReadLine();
            userNumber = int.Parse(sNumber);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        int sum = 0;
        int largest = -999999;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}