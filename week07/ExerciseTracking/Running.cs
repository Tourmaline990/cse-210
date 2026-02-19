public class Running : Activity
{
    private double _distance;
    
    public Running(double distance, string date, int minute): base(date,"Running",minute)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / GetMinute() * 60;
    }
    public override double Pace()
    {
        return  GetMinute() / _distance;
    }

}