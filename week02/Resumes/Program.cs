using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

         Job job1 = new Job ();
         job1._company = "chowdeck";
        job1._jobTitle = "vendor Assistant";
        job1._startYear = 2025;
        job1._endYear = 2026;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "CEO";
        job2._startYear = 2028;
        job2._endYear = 2060;
        job2.Display();

         
        Resume rems = new Resume();
        rems._name = "Edward Bernay";
        rems._jobs.Add(job1);
        rems._jobs.Add(job2);
        rems.DisplayResume();



    }
    
    

 
}
