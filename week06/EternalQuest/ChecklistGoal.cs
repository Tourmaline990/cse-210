public class ChecklistGoal : Goal
{
   private int _amountCompleted;
   private int _target;
   private int _bonus;

   public ChecklistGoal(string name,string desc,int points,int target,int bonus) : base(name,desc,points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;

    }
    public override void RecordEvent()
    {
       if(_amountCompleted < _target)
        {
            _amountCompleted ++;
        }
    }
    public override bool IsComplete()
    {
       bool value = false;
        if (_target == _amountCompleted)
        {
             value = true;
        }
        return value;
    }
    public override string GetStringRepresentation()
    {
        return $"{Check(IsComplete())} ~ {GetPoint()} gems ~ {GetName()} ~ ({GetDescription()}) ~ Completed {_amountCompleted}/{_target} ~ Bonus - {_bonus} points ";
    }
    public override string GetDisplayString()
    {
       // string x = Check(IsComplete());
        return $"{Check(IsComplete())} {GetName()}({GetDescription()}) --- Completed {_amountCompleted}/{_target}";
    }
    public override int EarnedPoint()
    {
        int amt = 0;
        if (IsComplete())
        {
            amt = GetPoint() + _bonus;
        }
        else
        {
            amt = GetPoint();
        }
        return amt;
    }
} 