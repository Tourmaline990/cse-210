using System.Diagnostics.CodeAnalysis;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string> ();
    private List<string> _Strings;

    public ListingActivity() : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    public void AddPromts(string prompt)
    {
        _prompts.Add(prompt);
    }
    public void Run()
    {
        DisplayStartingMesssage();
        Console.WriteLine("List as many response as you can to the following prompt");
        GetRandomPrompt();
        Console.Write($"You may begin in....");
        ShowCountDown(5);
        Console.WriteLine("");
        GetListFromUser();
        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();

    }
    public int GetCount()
    {
        return _count;
    }
    public void GetRandomPrompt()
    {
        if (_Strings == null || _Strings.Count == 0)
        {
            ResetAvailablePrompts();
        }
        Random random =  new Random();
        int randomIndex = random.Next(_Strings.Count);
        Console.WriteLine($"---{_Strings[randomIndex]}---");
        _Strings.RemoveAt(randomIndex);
        
        
    }
    private void ResetAvailablePrompts()
    {
        _Strings = new List<string>(_prompts);
    }
    public List<string> GetListFromUser()
    {
        List<string> userlist = new List<string>();
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(GetDuration());
        
        while (DateTime.Now < future )
        {
          Console.Write("> ");
           string input = Console.ReadLine();
           userlist.Add(input); 
           _count ++;
           
        } 
        return userlist;
    }
}