class PointsManager
{
    private int _totalPoints;
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.\n");
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

}