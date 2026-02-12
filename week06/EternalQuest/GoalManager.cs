using System.Drawing;
using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals  = new List<Goal>();
    private int _score;

    public GoalManager(){
        
    }
    public void Start()
    {
        Creativity();
        int menu = 0;
        while (menu != 6)
        {
            
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = int.Parse(Console.ReadLine());
            if(menu == 1)
            {
                CreateGoal();
            }
            else if (menu == 2)
            {
                ListGoalDetails();
            }
            else if (menu == 3)
            {
                Console.WriteLine("Enter a filename for the Goal:  ");
                string filename = Console.ReadLine();
                SaveGoal(filename);
            }
            else if (menu == 4)
            {
                Console.WriteLine("Enter the filename for the Goal:  ");
                string filename = Console.ReadLine();
                LoadGoal(filename);
            }
            else if (menu == 5)
            {
                RecordEvent();
            }
            else if (menu == 6)
            {
                Console.WriteLine("Would you like to make a donation for country Z childrens?");
                Console.WriteLine("Yes or no?");
                string ans = Console.ReadLine().ToLower();
                if (ans == "yes")
                {
                    Console.WriteLine($"You have donated {_score} gems to Country Z");
                    Console.WriteLine("Good job !!");
                }
                else
                {
                    Console.WriteLine($"Goodbye");
                }
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} Points.");
    }
    public void ListGoalNames()
    {
        int num = 0;
        foreach (Goal x in _goals)
        {
            num++;
            Console.WriteLine($"{num}. {x.GetName()}");
        }
        
    }
    public void ListGoalDetails()
    {
        foreach (Goal x in _goals)
        {
           Console.WriteLine(x.GetDisplayString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of Goal will you like to create: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int response = int.Parse(Console.ReadLine());
        if (response == 1)
        {
            SimpleGoal simple = new SimpleGoal();
            Console.Write("What is the name of the Goal? ");
            simple.SetName(Console.ReadLine());
            Console.Write("What is the short description of it? ");
            simple.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of point associatd with this goal? ");
            simple.SetPoint(int.Parse(Console.ReadLine()));
            _goals.Add(simple);
        }
        else if (response == 2)
        {
          Console.Write("What is the name of the Goal? "); 
          string name = Console.ReadLine();
          Console.Write("What is the short description of it? ");
          string desc = Console.ReadLine();
          Console.Write("What is the amount of point associatd with this goal? ");
          int point = int.Parse(Console.ReadLine());
          EternalGoal eternal = new EternalGoal(name,desc,point);
          _goals.Add(eternal);
        }
        else if (response == 3)
        {
          Console.Write("What is the name of the Goal? "); 
          string name = Console.ReadLine();
          Console.Write("What is the short description of it? ");
          string desc = Console.ReadLine();
          Console.Write("What is the amount of point associatd with this goal? ");
          int point = int.Parse(Console.ReadLine());
          Console.Write("How many times does this goal need to be accomplished for a bonus? ");
          int target = int.Parse(Console.ReadLine());
          Random random = new Random();
          int bonus = random.Next(1,501);
          Console.WriteLine($"You can earn a bonus of {bonus} point if you complete  your goal");
          ChecklistGoal checklist = new ChecklistGoal(name,desc,point,target,bonus);
          _goals.Add(checklist); 
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The Goals are: ");
        ListGoalNames();
        Console.WriteLine("Which Goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine());
        Goal goal = _goals[i - 1];
        goal.RecordEvent();
       int  point  = goal.EarnedPoint();
        if (point <= 0)
        {
          Console.WriteLine($"Congratulations! you have earned {goal.GetPoint()} points");  
           _score += goal.GetPoint();
        }
        else if (point > 0)
        {
            Console.WriteLine($"Congratulations! you have earned {point} points") ;
            _score += point;
        }
       
        

    }
    public void SaveGoal(string filename)
    {
        using (StreamWriter writtenfile = new StreamWriter(filename))
        {
            foreach (Goal x in _goals)
            {
                writtenfile.WriteLine(x.GetStringRepresentation());
            } 
        }
    }
    public void LoadGoal(string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string l in lines)
        {
           string [] part = l.Split("~");
          // for (int i = 0; i <= part.Length; i++ )
          //  {
                
         //   }
         //   string check =  part[0];
         //  string name = part[1];
        //   string desc = part[2];
         //  string comp = part[3];

         //  Console.WriteLine($"{check} {name} {desc} {comp}");

           foreach (string x in part)
           {
             Console.Write($"{x}");
           }
           Console.WriteLine("");
        }
        Console.WriteLine("\n");
    }
    public void Creativity()
    {
        Console.Write("Accomplishing 'Goals' that aids your 'Growth', earns you 'Gems' that can be used to cater for children in country Z");
        Thread.Sleep(3000);
        Console.Clear();
        Console.Write("Quests completed. Gems earned.");
        Thread.Sleep(3000);
        Console.Clear();
        Console.Write("Your progress helps children in Country Z.");
        Thread.Sleep(3000);
        Console.Clear();
        List<string> strings = new List<string>();
        strings.Add("|");
        strings.Add("/");
        strings.Add("-");
        strings.Add("\\");
        strings.Add("-");
        strings.Add("|");
       strings.Add("/");
       strings.Add("-");
        strings.Add("\\");

        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(5);
        int i = 0;
        while (DateTime.Now < future)
        {
            string s = strings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;

            if (i >= strings.Count)
            {
                i = 0;
            }
        }
        Console.Write("Begins in .....");
        Thread.Sleep(1000);
        for (int x = 5; x >= 0; x--)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
       
    }
}