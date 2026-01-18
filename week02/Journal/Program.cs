using System;
using System.ComponentModel.Design;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {


        // FOR EXTRA CREATIVITY:
            //  I increased the menu choices to 7, to allow users save the journal as a json format and also load it 
            // Deserialization.
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal UserJournal = new Journal();
        int menu = 0;
        while (menu!= 7)
        {


            PromptGenerator prompt1 = new PromptGenerator();
            prompt1._prompts.Add("If i had one thing i could do over today what would that be? ");
            prompt1._prompts.Add("Who was the most interesting person I interacted with today? ");
            prompt1._prompts.Add("What was the best part of my day? ");
            prompt1._prompts.Add("How did I see the hand of the Lord in my life today? ");
            prompt1._prompts.Add("What was the strongest emotion I felt today? ");
            
            prompt1._prompts.Add("What did i learn today that i was ignorant of yesterday? ");
            prompt1._prompts.Add("If my actions today reflected who i am, what will i improve or curtail?  ");
            prompt1._prompts.Add("Was i compassionate to myself?");
            prompt1._prompts.Add("What did i put honest effort into today?  ");

            string promptResult = prompt1.GetRandomPrompts();
           

            
            
            

            Console.WriteLine("Please Select One Of The Following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load as txt");
            Console.WriteLine("4. Save as txt");
            Console.WriteLine("5. Save as Json");
            Console.WriteLine("6. Load as json");
            Console.WriteLine("7. Quit");

            Console.Write("What would you like to do: ");
            menu = int.Parse(Console.ReadLine());
            if(menu == 1)
            {
                Console.WriteLine($"{promptResult}");
                Console.Write("> ");
                string userReturn = Console.ReadLine(); 
                Entry userEntry = new Entry();
                DateTime theCurrentDate = DateTime.Now;
                string dateText = theCurrentDate.ToShortDateString();
                userEntry._date = dateText;
                userEntry._promptText = promptResult;
                userEntry._entryText = userReturn;

                UserJournal.AddEntry(userEntry);
            }
            else if(menu == 2){
            
            UserJournal.DisplayAll();
            }
            else if(menu == 3)
            {
               Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                Console.WriteLine("Reading from file...."); 
                UserJournal.LoadFromFile(filename);
            }
            else if(menu == 4)
            {
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                Console.WriteLine("Saving to file....");
                UserJournal.SaveToFile(filename);
                

            }
            else if (menu == 5)
            {
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                Console.WriteLine("Saving to file....");
                UserJournal.SaveToJson($"{filename}");
            }
            else if(menu == 6)
            {
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                Console.WriteLine("Loading from  file....");
                UserJournal.ReadFromJson(filename);
            }
            
            
            
            

            
            

            

        }

    }
    
}