using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
         string again = "YES";
        while (again == "YES")
        {
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1,100);
           int guessNum = 0;
        int count = 0;
          
        while (guessNum != magicNumber )
        {
          Console.Write("What is the your guess: ");
          count ++;
           string guessed = Console.ReadLine();
           guessNum = int.Parse(guessed);
          if(guessNum > magicNumber)
          {
            Console.WriteLine("Lower");
          }
          else if(guessNum < magicNumber)
          {
            Console.WriteLine("Higher");
          }
          else
          {
            Console.WriteLine("You guessed it!");
          }   
          
        }
        Console.WriteLine($"It took you {count} guesses.");
        Console.WriteLine("Would you like to play again? Yes/No");
        again = Console.ReadLine();
        again = again.ToUpper();
       
    } 
        }
        
        
}