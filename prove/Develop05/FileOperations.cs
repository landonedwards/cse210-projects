using System.IO;
public class FileOperations
{
    private string _fileName;

    // methods

    public FileOperations(string _fileName = "unknown")
    {
    }

    public void SaveToFile(List<Goal> goals, string fileName)
    {
        using (StreamWriter outputFile = new(fileName))
        {
            foreach (Goal goal in goals)
            {
                string formattedGoal = goal.FormatGoal();
                outputFile.WriteLine(formattedGoal);
            }
        }
    }

    public List<Goal> LoadFromFile(string fileName)
    {
        List<Goal> goals = new();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalData = parts[1];

            Goal newGoal = CreateGoal(goalType, goalData);
            goals.Add(newGoal);
        }

        return goals;
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
                return new SimpleGoal(name, description, points);

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