public class Biking : Activity
{
    //member variables unique to biking
    private double _speed;

    //constructor to assign value to variables
    public Biking(DateTime date, int minutes, double speed)
        : base (date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

}

