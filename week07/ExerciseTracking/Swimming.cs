public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return Math.Round(_length / GetDistance(), 1);
    }
    
    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _length) * 60, 1);
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length})- Distance {Math.Round(GetDistance(), 1)} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}