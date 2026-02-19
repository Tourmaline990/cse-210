public abstract class  Activity
{
    private int _minute;
    private string _date;
    private string _activityName;

     
    public Activity()
    {
        
    }
    public Activity(string date, string activityName, int length_in_min)
    {
        _date = date;
        _activityName = activityName;
        _minute = length_in_min;
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public string GetSummary()
    {
        return  $"{_date} {_activityName} ({_minute} min) - Distance {Math.Round(Distance())} miles, Speed {Math.Round(Speed(),2)} mph, Pace {Math.Round(Pace(),2)} min per mile.";
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetMinute()
    {
        return _minute;
    }
}