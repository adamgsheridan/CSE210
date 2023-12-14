using System.IO;
class GoalManager
{
    Goal singleGoal = new Goal();
    
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
            //Console.WriteLine(goal);
            goal.DisplayContents(count);
            count++;
        }

    }
    public void SaveGoals()
    {
        string filename = "goals.txt";
        foreach (Goal goal in _goals)
        {
            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                outputFile.WriteLine(goal.CreateString());
            }
        }
    }
    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':', '|');
                // Text pt 1.
                string name = parts[1];
                // Console.Write($"{name}");
                // Text pt 2.
                string description = parts[2];
                // Console.Write($"{description}");
                // Points.
                int points = int.Parse(parts[3]);
                // Console.Write($"{points}");
            if(parts[0] == "SimpleGoal")
            {
                // IsChecked.
                bool isChecked = bool.Parse(parts[4]);
                // Console.WriteLine($"{isChecked}");
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
                goal.CheckGoal();
            }
            count++;
        }
    }
}