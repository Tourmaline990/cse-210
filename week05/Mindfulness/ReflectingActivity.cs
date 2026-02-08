public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _question  = new List<string>();
    private List<string> _questionDuplicate;
    private List<string> _PromptsDuplicate;

    public ReflectingActivity() : base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    public void Run()
    {
        
      DisplayStartingMesssage();
      Console.WriteLine("Consider The Following Prompts: ");
      DisplayPrompt();
      Console.WriteLine("When you have something in mind, press enter to continue");
      Console.ReadLine();
      Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
      Console.WriteLine("You may begin in: ");
      ShowCountDown(5);


      DateTime now = DateTime.Now;
      DateTime future = now.AddSeconds(GetDuration());
      while (DateTime.Now< future)
      {
        DisplayQuestion();
        ShowSpinner(5);
        Console.WriteLine("");
      }
      DisplayEndingMessage();
            
    }

    public void Addprompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    public void Addquestion(string question)
    {
       _question.Add(question);
    }
    public string GetRandomPrompt()
    { 
         if (_PromptsDuplicate == null || _PromptsDuplicate.Count == 0)
        { 
            RefillPrompts();
        }
        Random random = new Random();
         int randomindex = random.Next(_PromptsDuplicate.Count);
         string p = _PromptsDuplicate[randomindex];
         _PromptsDuplicate.RemoveAt(randomindex);
          return p;
    }
    public string GetRandomquestion()
    {
        if (_questionDuplicate == null || _questionDuplicate.Count == 0)
        { 
            RefillQuestion();
        }
        Random random = new Random();
        Thread.Sleep(1000);
        int randomindex = random.Next(_questionDuplicate.Count);
        string quest =_questionDuplicate[randomindex];
        _questionDuplicate.RemoveAt(randomindex);
        return quest;
    }
    public void DisplayPrompt()
    {
        string get = GetRandomPrompt();
        Console.WriteLine($"--- {get} ---");
    }
    public void DisplayQuestion()
    {
        string store =  GetRandomquestion();
        Console.Write($"> {store} ");
    }
    private void RefillQuestion()
    {
        _questionDuplicate = new List<string>(_question);
    }
    private void RefillPrompts()
    {
        _PromptsDuplicate = new List<string>(_prompts);
    }
}