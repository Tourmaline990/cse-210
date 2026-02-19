using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine("");
         DateTime date = DateTime.Now;
         string currentdate = date.ToShortDateString();
        

        // Swimming
        Swimming swimming = new Swimming(100d,currentdate,30);
        Swimming swim = new Swimming(50d,currentdate,40);
        // Cycling
        Cycling cycling = new Cycling(30d,currentdate,20);
        Cycling cycle = new Cycling(40d,currentdate,40);
        //Running
        Running running  = new Running(1500,currentdate,60);
        Running run  = new Running(150,currentdate,30);
       

       List<Activity> activities = new List<Activity>();
       activities.Add(swimming);
       activities.Add(swim);
       activities.Add(cycling);
       activities.Add(cycle);
       activities.Add(running);
       activities.Add(run);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}