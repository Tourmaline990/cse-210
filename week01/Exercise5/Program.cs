using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplaysWelcomeMsg();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplaysResult(userName,squared);


    
      static void DisplaysWelcomeMsg()
      {
        Console.WriteLine("Welcome to the Program!");
      }
      static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
       static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int fav = int.Parse(Console.ReadLine());
            return fav;
        }
        static int SquareNumber(int square)
        {
            int squared = square * square;
            return squared;
        }
        static void DisplaysResult(string name,int number)
        {
            Console.WriteLine($"{name} the square of your number is {number}");
        }

       
    }  
    
}