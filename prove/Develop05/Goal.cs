class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isChecked = false;
    public string GetName()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        return name;
    }
    public string GetDescription()
    {
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        return description;
    }
    public void SetText()
    {}

    public int GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        return int.Parse(Console.ReadLine());
    }
    public void AddPoints()
    {}
    virtual public int CheckGoal()
    {
        return 0;
    }

    virtual public void DisplayContents(int count)
    {}
    virtual public void DisplayGoalName()
    {}
    public bool IsChecked()
    {
        return _isChecked;
    }
    virtual public string CreateString()
    {
        return "";
    }
}