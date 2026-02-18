public class Bicycle : Activity
{
    private double _speed;
    public Bicycle(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(_speed * (_length / 60), 1);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 1);
    }
    
    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}