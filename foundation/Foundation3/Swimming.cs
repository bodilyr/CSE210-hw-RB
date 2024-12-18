public class Swimming : Activity
{
    //member variables unique to swimming
    private int _laps;

    //constructor to assign value to variables
    public Swimming(DateTime date, int minutes, int laps)
        : base (date, minutes)
    {
        _laps = laps;
    }

    //overriding abstract members from Activity class
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() *60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }


}