public class Cycling: Activity
{
    private double _speed;

    public Cycling(double speed, string date, int minute):base(date,"Cycling",minute)
    {
        _speed = speed;
    }
    public override double Distance()
    {
       return _speed * GetMinute() / 60;
    }
    public override double Pace()
    {
        return GetMinute() / Distance();
    }
    public override double Speed()
    {
        return _speed;
    }
}