public class Running : Activity
{
    private double _distance;
    
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return Math.Round(_length / _distance, 1);
    }
    
    public override double GetSpeed()
    {
        return Math.Round((_distance / _length) * 60, 1);
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}