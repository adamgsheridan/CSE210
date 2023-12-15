using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int selector = 0;
        int goalType;

        GoalManager goalManager = new GoalManager();
        Goal goal = new Goal();

        while (selector != 6)
        {
            goalManager.DisplayPoints();
            menu.DisplayMenu();
            selector = menu.GetSelector();
            if (selector == 1)
            {

                menu.DisplayGoalTypes();
                goalType = menu.GetGoalType();
                string name = goal.GetName();
                string description = goal.GetDescription();
                int points = goal.GetPoints();
                if (goalType == 1)
                {
                    // Simple goal.
                    bool isChecked = goal.IsChecked();
                    Goal simpleGoal = new SimpleGoal(name, description, points, isChecked);

                    goalManager.AddGoal(simpleGoal);
                }
                else if (goalType == 2)
                {
                    // Eternal goal.
                    Goal eternalGoal = new EternalGoal(name, description, points);
                    goalManager.AddGoal(eternalGoal);
                }
                else if (goalType == 3)
                {
                    // Checklist goal.
                    int checkMax = ChecklistGoal.GetCheckMax();
                    int goalsChecked = 0;
                    int bonus = ChecklistGoal.GetBonus();
                    Goal checklistGoal = new ChecklistGoal(name, description, points, checkMax, goalsChecked, bonus);
                    goalManager.AddGoal(checklistGoal);
                }
            }
            else if (selector == 2)
            {
                goalManager.ListGoals();
            }
            else if (selector == 3)
            {
                goalManager.SavePoints();
                goalManager.SaveGoals();
            }
            else if (selector == 4)
            {
                goalManager.LoadPoints();
                goalManager.LoadGoals();
            }
            else if (selector == 5)
            {
                goalManager.RecordGoals();
            }
        }
    }
}