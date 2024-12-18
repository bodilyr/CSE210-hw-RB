using System.Dynamic;

public abstract class Activity
{
    //member variables in common with derived classes
    private DateTime _dateActivity;
    private int _minutesActivity;
    
    //constructor to assign values to variables
    public Activity(DateTime date, int minutes)
    {
        _dateActivity = date;
        _minutesActivity = minutes;
    }

    public DateTime GetDate() => _dateActivity;
    public int GetMinutes() => _minutesActivity;

    //methods and functions
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_dateActivity.ToShortDateString()} {this.GetType().Name}  ({_minutesActivity} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}