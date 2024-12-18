public abstract class Goal
{
    //member varialbles
    protected string _shortName;
    protected string _description;
    protected int _points;

    //constructor to assign values to variables
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //methods and functions common to all child classes
    public int Points
    {
        get { return _points; }
    }
    
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} - Points:  {_points}";
    }

    public abstract string GetStringRepresentation();

}