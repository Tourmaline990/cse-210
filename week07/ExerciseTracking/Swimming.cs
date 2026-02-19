public class Swimming: Activity
{
    private double _swimmingLaps;
    public Swimming(double laps, string date, int minute) : base(date,"Swimming",minute)
    {
        _swimmingLaps = laps;
    }
    public override double Distance()
    {
       return  _swimmingLaps * 50 / 1000 * 0.62;
    }
    public override double Speed()
    {
        return Distance() / GetMinute() * 60;
    }
    public override double Pace()
    {
        return GetMinute() / Distance();
    }
}