class EternalGoal : Goal
{
    public new void CheckGoal()
    {}
    public new bool IsChecked()
    {
        return false;
    }
    public EternalGoal(string _name, string _description, int _points)
    {
        this._name = _name;
        this._description = _description;
        this._points = _points;
    }
    public override void DisplayContents(int count)
    {
        Console.WriteLine($"{count}. [ ] {_name} ({_description})");
    }

    public override void DisplayGoalName()
    {
        Console.WriteLine($"{_name}");
    }
    public override string CreateString()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}