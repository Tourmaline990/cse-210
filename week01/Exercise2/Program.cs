using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        string letter = "";
        string sign = "";
        


        Console.Write("Enter your grade percentage: ");
        string value = Console.ReadLine();

        int val = int.Parse(value);
          if (val % 10 >= 7)
          {
            sign = "+";
          }
           else if(val % 10 < 3)
          {
             sign = "-";
          }
        
        if(val >= 90)
        {
            letter = "A";
           // Console.WriteLine($"{letter}");
        }
        else if(val >= 80)
        {
           // Console.WriteLine("B");
            letter = "B";
        }
        else if(val >= 70)
        {
           // Console.WriteLine("C");
            letter = "C";
        }
        else if(val >= 60)
        {
            //Console.WriteLine("D");
             letter = "D";
        }
        else if(val < 60)
        {
           // Console.WriteLine("F");
            letter = "F";
        }
        if(val % 10 >= 7 && letter == "A"|| letter == "F")
        {
           Console.WriteLine($"{letter}"); 
        }
        else
        {
          Console.WriteLine($"{letter}{sign}");  
        }
        

       if (val >= 70)
        {
            Console.WriteLine("Congratulations, You passed the course!");
        }
        else
        {
           Console.WriteLine("Try again, and try better."); 
        }

       

    }
}