using System.IO;
class GoalManager
{
    private int _totalPoints;
    public List<Goal> _goals = new List<Goal>();
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ListGoals()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            goal.DisplayContents(count);
            count++;
        }
    }
    public void SaveGoals()
    {
        string filename = "goals.txt";
        foreach (Goal goal in _goals)
        {
            if(!File.ReadAllText(filename).Contains(goal.CreateString()))
            {
                using (StreamWriter outputFile = new StreamWriter(filename, true))
                {
                    outputFile.WriteLine(goal.CreateString());
                }
            }
            
        }
    }
    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if(line != lines[0])
            {
                string[] parts = line.Split(':', '|');
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                if(parts[0] == "SimpleGoal")
                {
                    bool isChecked = bool.Parse(parts[4]);
                    Goal simpleGoal = new SimpleGoal(name, description, points, isChecked);
                    AddGoal(simpleGoal);
                }
                else if(parts[0] == "EternalGoal")
                {
                    Goal eternalGoal = new EternalGoal(name, description, points);
                    AddGoal(eternalGoal);
                }
                else
                {
                    int bonus = int.Parse(parts[4]);

                    int checkMax = int.Parse(parts[5]);

                    int goalsChecked = int.Parse(parts[6]);

                    Goal checklistGoal = new ChecklistGoal(name, description, points, checkMax, goalsChecked, bonus);
                    AddGoal(checklistGoal);
                }
            }
            
        }
    }
    public void RecordGoals() {
        Console.Write("The goals are:\n");
        int count = 1;
        foreach(Goal goal in _goals)
        {
            Console.Write($"{count}. ");
            goal.DisplayGoalName();
            count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        count = 1;
        foreach(Goal goal in _goals)
        {
            if(count == choice)
            {
                _totalPoints += goal.CheckGoal();
            }
            count++;
        }
    }
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.\n");
    }

    public void SavePoints()
    {
        string filename = "goals.txt";
        string[] saveFile = File.ReadAllLines(filename);
        saveFile[0] = $"{_totalPoints}";
        File.WriteAllLines(filename, saveFile);
    }

    public void LoadPoints()
    {
        _totalPoints = int.Parse(File.ReadLines("goals.txt").First());
    }
}