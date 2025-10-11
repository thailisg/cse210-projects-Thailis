using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetNames()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        string marked;
        if (IsComplete() == true)
        {
            marked = "[X]";
        }

        else
        {
            marked = "[ ]";
        }

        return marked + base.GetDetailsString() + $" - Currently completed {_amountCompleted} / {_target}";
    }

    public int GetBonus()
    {
        return _bonus;
    }

}