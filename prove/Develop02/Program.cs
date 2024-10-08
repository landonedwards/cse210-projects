using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = -99;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");

            string stringChoice = Console.ReadLine();
            choice = int.Parse(stringChoice);


            if (choice == 1)
            {

            }

            else if (choice == 2)
            {

            }

            else if (choice == 3)
            {

            }

            else if (choice == 4)
            {

            }
        }
        while (choice != 5);
    }
}