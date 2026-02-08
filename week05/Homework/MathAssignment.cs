public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string studentname,string topic,string textBookSection,string problems): base(studentname,topic)
    {
       _textBookSection = textBookSection;
       _problems = problems;
    
    }
    public string GetHomeWorkList()
    {
        return $"{GetSummary()}\n{_textBookSection} {_problems}";
    }
}