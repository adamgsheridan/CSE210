class ChecklistGoal : Goal
{
    private int _goalsChecked = 0;
    private int _bonus;
    private int _checkMax;
    public override int CheckGoal()
    {
        _goalsChecked++;
        if(_checkMax == _goalsChecked)
        {
            _isChecked = true;
            return _bonus + _points;
        }
        else if(_checkMax < _goalsChecked)
        {
            return _points;
        }
        else
        {
            _goalsChecked--;
            return 0;
        }
    }
    public void SetTotalPoint()
    {}

    public static int GetCheckMax()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        return int.Parse(Console.ReadLine());
    }
    public static int GetBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        return int.Parse(Console.ReadLine());
    }
    public ChecklistGoal(string _name, string _description, int _points, int _checkMax, int _goalsChecked, int _bonus)
    {
        this._name = _name;
        this._description = _description;
        this._points = _points;
        this._checkMax = _checkMax;
        this._goalsChecked = _goalsChecked;
        this._bonus = _bonus;
    }
    public override void DisplayContents(int count)
    {
        string check;
        if(IsChecked())
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        Console.WriteLine($"{count}. {check} {_name} ({_description}) -- Currently Completed: {_goalsChecked}/{_checkMax}");
    }
    public override void DisplayGoalName()
    {
        Console.WriteLine($"{_name}");
    }
    public override string CreateString()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonus}|{_checkMax}|{_goalsChecked}";
    }
}