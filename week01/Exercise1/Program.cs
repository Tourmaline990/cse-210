using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

      //  Console.Write("What is your first name? ");
      //  string Fname  = Console.ReadLine();
      //  Console.Write("What is your  last name? ");
      //  string lname = Console.ReadLine();
        
      //  Console.WriteLine($"Your name is {lname}, {Fname} {lname}.");



        Console.WriteLine("\nFor Core Requirement 3:");
       string play_again = "yes";
       while (play_again == "yes") //for stretch challenge
       {
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1, 101);
           int guess = -1;
           int counter = 0; //Tracking counter to know how many guesses have been made.
           while (guess != magicNumber)
           {
               counter += 1;
               Console.Write($"{counter} try: What is your guess? ");
               guess = int.Parse(Console.ReadLine());
               if (magicNumber > guess)
               {
                   Console.WriteLine("Higher");
               }
               else if (magicNumber < guess)
               {
                   Console.WriteLine("Lower");
               }
               else
               {
                   Console.WriteLine("You guessed it!");
                   Console.WriteLine($"You did it in {counter} tries");//show how many guesses have been made.
               }
           }
           Console.Write("Do you want to play again? (write: yes or no) ");// "no" for exit of the loop
           play_again = Console.ReadLine();
       }
    }
}