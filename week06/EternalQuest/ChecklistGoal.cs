
public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(
        string name, string description, int points,
        int target, int bonus, int completed = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _completed++;

        int earned = GetPoints();

        if (_completed == _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetDetails()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {GetName()} - {GetDescription()} " +
               $"Completed {_completed}/{_target} times";
    }

    public override string SaveData()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|" +
               $"{GetPoints()}|{_target}|{_bonus}|{_completed}";
    }
}
