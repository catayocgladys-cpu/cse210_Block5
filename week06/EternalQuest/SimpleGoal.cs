//A goal that can be completed once.


public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(
        string name, string description, int points,
        bool complete = false)
        : base(name, description, points)
    {
        _complete = complete;
    }

    public override int RecordEvent()
    {
        if (_complete)
        {
            return 0;
        }

        _complete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetDetails()
    {
        string status = _complete ? "[X]" : "[ ]";
        return $"{status} {GetName()} - {GetDescription()}";
    }

    public override string SaveData()
    {
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoints()}|{_complete}";
    }
}
