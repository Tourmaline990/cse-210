using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {


        // FOR EXTRA CREATIVITY:
            //  I added nested if statements in menu choice 3 and 4 to allow the users decide if they want to load or save the file as json or txt 
            //   using json serialization and deserialization.
        Console.WriteLine("Hello World! This is the Journal Project.");

           
         Journal userjournal = new Journal();
        
         
         int choice = 0;
         while (choice != 5)
         {

            PromptGenerator prompt1  = new PromptGenerator();
           prompt1._prompts.Add("If i had one thing i could do over today what would that be? ");
           prompt1._prompts.Add("If i had one thing i could do over today what would that be? ");
           prompt1._prompts.Add("What was the best part of my day? ");
           prompt1._prompts.Add("How did I see the hand of the Lord in my life today? ");
           prompt1._prompts.Add("What was the strongest emotion I felt today? ");
           prompt1._prompts.Add("What did i learn today that i was ignorant of yesterday?");
           prompt1._prompts.Add("If my actions today reflected who i am, what will i improve or curtail?  ");
           prompt1._prompts.Add("Was i compassionate to myself?");
           prompt1._prompts.Add("What did i put honest effort into today?  ");

           string randomprompt =   prompt1.GetRandomPrompt();

             Entry userEntry = new Entry();
            Console.WriteLine("Please Select One Of The Following Choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

           
            Console.WriteLine("What will you like to do: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
               
               Console.WriteLine(randomprompt);
               Console.Write("> ");
               string promptresponse = Console.ReadLine();
               userEntry._promptText = randomprompt;
               userEntry._entryText = promptresponse;
               DateTime theCurrentTime = DateTime.Now;
               string dateText = theCurrentTime.ToShortDateString();
               userEntry._date = dateText;
               userjournal.AddEntry(userEntry);
               
            }
            else if (choice == 2)
            {
                userjournal.DisplayAll();
            }
            else if (choice == 3)
            {
               Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                Console.WriteLine("> Loading From file....");
                Console.WriteLine("Load file as Json Or Txt? ");
                Console.Write("> ");
                string filetype = Console.ReadLine().ToLower();
                if (filetype == "txt")
                {    
                  userjournal.LoadFromFile(filename);
                }
                else
                {
                   userjournal.ReadFromJson(filename);
                }
                
                Console.WriteLine("Loaded"); 
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                Console.WriteLine("> Saving to file....");
                Console.WriteLine("Save file as Json Or Txt? ");
                Console.Write("> ");
                string filetype = Console.ReadLine().ToLower();
                if (filetype == "txt")
                {    
                  userjournal.SaveToFile(filename);
                }
                else
                {
                   userjournal.SaveToJson(filename);
                }
                Console.WriteLine("saved");
            }
            else
            {
                Console.WriteLine("Keep Building Awareness!");
            }
            
         }
        



            
           

            
            
            
    }

}