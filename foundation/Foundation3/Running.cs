public class Running : Activity
{
    //member variables unique to running
    private double _distance;

    //constructor to assign values to variables
    public Running(DateTime date, int minutes, double distance)
        : base (date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }
}