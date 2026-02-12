public class EternalGoal : Goal
{
    public EternalGoal(string name, string descr,int point) : base(name,descr,point)
    {
        
    }

    public override void RecordEvent()
    {
       
    }
    public override bool IsComplete()
    {
       return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{Check(IsComplete())} ~ {GetPoint()} gems ~ {GetName()} ~ ({GetDescription()})";
    }
}