using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program.");
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        User user = new(userName);
        FileOperations fileOps = new();

        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nHello {userName},\n");
            user.DisplayPoints();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("\nThe type of Goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");

                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.Write("What is the name of the goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("Please provide a short description of it: ");
                    string goalDescription = Console.ReadLine();

                    Console.Write("How many points should this goal be worth? ");
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
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            string stringCount = Console.ReadLine();
                            int targetCount = int.Parse(stringCount);

                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            string stringBonus = Console.ReadLine();
                            int bonusPoints = int.Parse(stringBonus);

                            ChecklistGoal newChecklist = new(goalName, goalDescription, goalPoints, bonusPoints, targetCount);
                            user.AddGoal(newChecklist);
                            break;

                        default:
                            Console.WriteLine("Not a valid goal. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\nThe goals are:");
                    user.DisplayGoals();
                    break;

                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFile = Console.ReadLine();
                    
                    List<Goal> goals = user.GetGoals();
                    int totalPoints = user.DisplayPoints();

                    fileOps.SaveToFile(goals, saveFile, userName, totalPoints);
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFile = Console.ReadLine();

                    (string loadedUserName, int loadedPoints, List<Goal> loadedGoals) = fileOps.LoadFromFile(loadFile);

                    user = new(loadedUserName);
                    user.AddPoints(loadedPoints);
                    user.RetrieveGoals(loadedGoals);
                    break;

                case "5":
                    user.DisplayGoals();

                    Console.Write("Which goal did you accomplish? ");
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
                
                default:
                    Console.WriteLine("Invalid option. Please choose one of the options in the menu.");
                    break;
            }

        }

    }
}