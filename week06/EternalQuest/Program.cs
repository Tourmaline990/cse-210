using System;

class Program
{
    static void Main(string[] args)
    {
        // For extra creativity, i added a creativity method in the Goal manager class, for animations and game idea 
        // i was able to come up with. Also,The bonus for Checklist goal will be chosen randomly by the program.
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        Console.Clear();
        manager.Start();
        
    }
}