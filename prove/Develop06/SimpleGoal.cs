public class SimpleGoal : Goal
{
    //member variable
    private bool _isComplete;

    //constructor to assign value to member variable
    public SimpleGoal(string name, string description, int points)
        : base (name, description, points)
    {
        _isComplete = false;
    }

    //override items from Goal abstract class that are needed for this class
    
    
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {_shortName}:  {_description} -- Points: {_points}";
        }
        else
        {
            return null;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, {_isComplete}";
    }

}
