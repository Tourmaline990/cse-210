public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal (string name,string description) : base(name,description)
    {
        
    }
    public SimpleGoal()
    {
        
    }

    public override void RecordEvent()
    {
        _isComplete = true;   
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{Check(IsComplete())} ~ {GetPoint()} gems ~ {GetName()} ~({GetDescription()})";
    }
}