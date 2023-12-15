class SimpleGoal : Goal
{
    public override int CheckGoal()
    {
        _isChecked = true;
        return _points;
    }
    public SimpleGoal(string _name, string _description, int _points, bool _isChecked)
    {
        this._name = _name;
        this._description = _description;
        this._points = _points;
        this._isChecked = _isChecked;
    }
    public override void DisplayContents(int count)
    {
        string check;
        if (IsChecked())
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        Console.WriteLine($"{count}. {check} {_name} ({_description})");
    }
    public override void DisplayGoalName()
    {
        Console.WriteLine($"{_name}");
    }
    public override string CreateString()
    {
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_isChecked}";
    }
}