public abstract class Goal
{
    private string _shortname;
    private string _description;
    private int _points;

    public Goal()
    {
        
    }
    public Goal(string name,string description)
    {
        _shortname = name;
        _description = description;
       
    }
    public Goal(string name,string description,int point)
    {
        _shortname = name;
        _description = description;
        _points = point;
       
    }
    public string GetName()
    {
        return _shortname;
    }
    public void SetName(string name)
    {
        _shortname = name;
    }
    public void SetDescription(string desc)
    {
        _description = desc;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoint()
    {
        return _points;
    }
    public void SetPoint(int point)
    {
       _points = point;
    }
    
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();

    public virtual string GetDisplayString()
    {
      //  string x = Check(IsComplete());
        return $" {Check(IsComplete())} {_shortname}({_description}) ";
    }
    public abstract string GetStringRepresentation();
    public  string Check(bool checks)
    {
       string check = "";
        if (checks)
        {
           check = "[x]";  
        }
        else
        {
            check = "[]"; 
        }
        return check;
    }
    public virtual int EarnedPoint()
    {
        return 0;
    }
    
}