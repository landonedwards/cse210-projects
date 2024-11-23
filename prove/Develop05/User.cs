using System.Runtime.InteropServices;

public class User
{
    private string _userName;
    private int _totalPoints;
    private int _level;
    private List<Goal> _goals;

    // methods

    public User(string userName)
    {
        _userName = userName;
        _totalPoints = 0;
        _level = 1;

        _goals = new();
    }

    public Goal GetGoal(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            return null;
        }

        goalIndex += 1;
        return _goals[goalIndex];
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        int initialLevel = _level;
        
        UpdateLevel();

        if (_level > initialLevel)
        {
            Console.WriteLine($"Great job! You just leveled up! You are now Lvl {_level}!");
        }
    }

    public void UpdateLevel()
    {
        if (_totalPoints > 500)
        {
            _level += 1;
            
            if (_totalPoints > 1200)
            {
                _level += 1;

                if (_totalPoints > 2000)
                {
                    _level += 1;
                }
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            int numGoal = 0;
            numGoal += 1;

            if (goal.IsComplete())
            {
                Console.WriteLine($"{numGoal}. [X] " + goal.DisplayGoal());
            }

            else
            {
                Console.WriteLine($"{numGoal}. [ ] " + goal.DisplayGoal());
            }
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine($"You are Lvl {_level}.");
    }

    public void RetrieveGoals(List<Goal> goals)
    {
        _goals = goals;
    }
}