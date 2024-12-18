public class ChecklistGoal : Goal
{
    //member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //constructor to assign value to variables
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //overriding methods and functions from abstract parent class Goal
    public int Bonus
    {
        get { return _bonus; }
    }
    
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} -- Points: {_points} -- Completed: {_amountCompleted}/{_target} -- Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";        
    }
}