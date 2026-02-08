 public class Activity
{
    private string _name;
    private string _desription;
    private int  _duration;
    
    public Activity(string name,string description)
    {
       _name = name;
       _desription = description;
      
    }
    public Activity()
    {
        _name = "Unknown";
        _desription = "Not given";
       _duration = 0;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMesssage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine("");
        Console.WriteLine($"{_desription}");
        Console.WriteLine("");
        Console.Write("How long in seconds, will you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Weldone!!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have  completed the {_name} activity, in {_duration} seconds");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        //  "|", "/", "-", "\\" 
       List<string> _animations = new List<string>();
        _animations.Add("|");
        _animations.Add("/");
        _animations.Add("-");
        _animations.Add("\\");
        _animations.Add("|");
        _animations.Add("/");
        _animations.Add("-");
        _animations.Add("\\");
       
        

        int i = 0;
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(seconds);
        while (DateTime.Now < future)
        {
            string s = _animations[i];
            Console.Write($"{s}");
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= _animations.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
      for (int i = seconds; i > 0; i--)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }  
    }
}