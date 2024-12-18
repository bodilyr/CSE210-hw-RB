public class EternalGoal : Goal
{
    //no member variables

    //constructor to assign values to parent class Goal
    public EternalGoal(string name, string description, int points)
        : base (name, description, points)
    {
    }

    //override abastract methods and functions 
    public override void RecordEvent()
    {
        //not needed because eternal goals are never "done"
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName}: {_description} -- {_points} (Eternal)";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, Eternal";
    }
}