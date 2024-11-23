using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program.");
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();

        User user = new(userName);

        bool running = true;

        while (running)
        {
            Console.WriteLine($"Hello {userName},");
            user.DisplayPoints();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("The type of Goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");

                    Console.WriteLine("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.WriteLine("What is the name of the goal? ");
                    string goalName = Console.ReadLine();

                    Console.WriteLine("Please provide a short description of it: ");
                    string goalDescription = Console.ReadLine();

                    Console.WriteLine("How many points should this goal be worth? ");
                    string stringPoints = Console.ReadLine();
                    int goalPoints = int.Parse(stringPoints);

                    switch (goalType)
                    {
                        case "1":
                            SimpleGoal newSimple = new(goalName, goalDescription, goalPoints);
                            user.AddGoal(newSimple);
                            break;

                        case "2":
                            EternalGoal newEternal = new(goalName, goalDescription, goalPoints);
                            user.AddGoal(newEternal);
                            break;

                        case "3":
                            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                            string stringCount = Console.ReadLine();
                            int targetCount = int.Parse(stringCount);

                            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                            string stringBonus = Console.ReadLine();
                            int bonusPoints = int.Parse(stringBonus);

                            ChecklistGoal newChecklist = new(goalName, goalDescription, goalPoints, targetCount, bonusPoints);
                            user.AddGoal(newChecklist);
                            break;

                        default:
                            Console.WriteLine("Not a valid goal. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("The goals are:");
                    user.DisplayGoals();
                    break;

                case "3":
                
                    break;

                case "4":

                    break;

                case "5":
                    user.DisplayGoals();

                    Console.WriteLine("Which goal did you accomplish? ");
                    string stringGoal = Console.ReadLine();
                    int goalIndex = int.Parse(stringGoal);

                    Goal selectedGoal = user.GetGoal(goalIndex);
                    int pointsEarned = selectedGoal.RecordEvent();
                    
                    user.AddPoints(pointsEarned);
                    break;

                case "6":
                    Console.WriteLine("Thank you for using the Eternal Quest program.");
                    running = false;
                    break;
            }

        }

    }
}