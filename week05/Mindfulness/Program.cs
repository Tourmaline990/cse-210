using System;

class Program
{
    // For extra Creativity; i filtered the prompts and questions, in reflecting and listing activity, so a prompt or question is displayed once until they are all Displayed before Repeating.
    static void Main(string[] args)
    {
        int userChoice = 0;
        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1.Breathing Activity");
            Console.WriteLine("2.Reflecting Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Quit");

            Console.Write("Select a Choice From The Menu: ");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
               if(userChoice == 1)
                {
                  BreathingActivity breathingActivity = new BreathingActivity();
                  breathingActivity.Run();
                 }
                else if (userChoice == 2)
                 {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Addprompt("Think of a time when you stood up for someone else.");
                reflectingActivity.Addprompt("Think of a time when you did something really difficult");
                reflectingActivity.Addprompt("Think of a time when you helped someone in need.");
                reflectingActivity.Addprompt("Think of a time when you did something truly selfless.");
                //QUESTIONS
                reflectingActivity.Addquestion("Why was this experience meaningful to you?");
                reflectingActivity.Addquestion("Have you ever done anything like this before?");
                reflectingActivity.Addquestion("How did you get started?");
                reflectingActivity.Addquestion("How did you feel when it was complete?");
                reflectingActivity.Addquestion("What made this time different than other times when you were not as successful?");
                reflectingActivity.Addquestion("What is your favorite thing about this experience?");
                reflectingActivity.Addquestion("What could you learn from this experience that applies to other situations?");
                reflectingActivity.Addquestion("What did you learn about yourself through this experience?");
                reflectingActivity.Addquestion("How can you keep this experience in mind in the future?");
                reflectingActivity.Run();
                }
               else if (userChoice == 3)
                 {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.AddPromts("Who are people that you appreciate?");
                listingActivity.AddPromts("What are personal strengths of yours?");
                listingActivity.AddPromts("Who are people that you have helped this week?");
                listingActivity.AddPromts("When have you felt the Holy Ghost this month?");
                listingActivity.AddPromts("Who are some of your personal heroes?");
                listingActivity.Run();
                 }
        }

    }
} 