public class BreathingActivity : Activity
{
   public BreathingActivity() : base("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Run()
    {  
        DisplayStartingMesssage();
        DateTime start = DateTime.Now;
        int duration = GetDuration();
        DateTime future = start.AddSeconds(duration);
        while (DateTime.Now < future)
        {
             List<string> _breathings = new List<string>();
             _breathings.Add("Breathe in....");
             _breathings.Add("Breathe out....");
            
            
                foreach (string item in _breathings)
                {
                Console.Write(item);
                ShowCountDown(5);
                Console.WriteLine("");
                
                }
                
                Console.WriteLine("");
                
               DisplayEndingMessage();
        }
    }
}