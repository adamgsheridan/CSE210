using System;
using System.Drawing;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int _selector = 0;
        int _goalType;

        GoalManager goalManager = new GoalManager();
        Goal goal = new Goal();
        PointsManager totalPoints = new PointsManager();
        
        while(_selector != 6)
        {
            totalPoints.DisplayPoints();
            menu.DisplayMenu();
            _selector = menu.GetSelector();
            if(_selector == 1)
            {
                
                menu.DisplayGoalTypes();
                _goalType = menu.GetGoalType();
                string name = goal.GetName();
                string description = goal.GetDescription();
                int points = goal.GetPoints();
                if(_goalType == 1){
                    // Simple goal.
                    bool isChecked = goal.IsChecked();
                    Goal simpleGoal = new SimpleGoal(name, description, points, isChecked);
                    
                    goalManager.AddGoal(simpleGoal);
                }
                else if(_goalType == 2){
                    // Eternal goal.
                    Goal eternalGoal = new EternalGoal(name, description, points);
                    goalManager.AddGoal(eternalGoal);
                }
                else if(_goalType == 3){
                    // Checklist goal.
                    int checkMax = ChecklistGoal.GetCheckMax();
                    int goalsChecked = 0;
                    int bonus = ChecklistGoal.GetBonus();
                    Goal checklistGoal = new ChecklistGoal(name, description, points, checkMax, goalsChecked, bonus);
                    goalManager.AddGoal(checklistGoal);
                }
            }
            else if(_selector == 2)
            {
                goalManager.ListGoals();
            }
            else if(_selector == 3)
            {
                goalManager.SaveGoals();
            }
            else if(_selector == 4)
            {
                goalManager.LoadGoals();
            }
            else if(_selector == 5)
            {
                goalManager.RecordGoals();
            }
        }
    }
}