using System.IO;
public class FileOperations
{
    private string _fileName;

    // methods

    public FileOperations(string fileName = "unknown")
    {
        _fileName = fileName;
    }

    public void SaveToFile(List<Goal> goals, string fileName, string userName, int totalPoints)
    {
        using (StreamWriter outputFile = new(fileName))
        {
            outputFile.WriteLine($"{userName}:{totalPoints}");

            foreach (Goal goal in goals)
            {
                string formattedGoal = goal.FormatGoal();
                outputFile.WriteLine(formattedGoal);
            }
        }
    }

    public (string userName, int totalPoints, List<Goal> goals) LoadFromFile(string fileName)
    {
        List<Goal> goals = new();

        string[] lines = File.ReadAllLines(fileName);

        string[] userInfo = lines[0].Split(":");
        string userName = userInfo[0];
        int totalPoints = int.Parse(userInfo[1]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string goalData = parts[1];

                Goal newGoal = CreateGoal(goalType, goalData);
                goals.Add(newGoal);
            }

        return (userName, totalPoints, goals);
    }

    public Goal CreateGoal(string goalType, string goalDetails)
    {
        string[] goalData = goalDetails.Split(",");

        string name = goalData[0];
        string description = goalData[1];
        int points = int.Parse(goalData[2]);

        switch(goalType)
        {
            case "SimpleGoal":
                bool isComplete = bool.Parse(goalData[3]);
                SimpleGoal simpleGoal = new(name, description, points);
                
                if (isComplete)
                {
                    simpleGoal.CompleteGoal();
                }
               
                return  simpleGoal;

            case "EternalGoal":
                return new EternalGoal(name, description, points);

            case "ChecklistGoal":
            
                int bonusPoints = int.Parse(goalData[3]);
                int targetCount = int.Parse(goalData[4]);
                int completionCount = int.Parse(goalData[5]);

                return new ChecklistGoal(name, description, points, bonusPoints, targetCount, completionCount);

            default:
                Console.WriteLine("Invalid goal type.");
                return null;
        }
    }
}