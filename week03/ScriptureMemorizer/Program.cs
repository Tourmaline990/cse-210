using System;

class Program
{
    static void Main(string[] args)
    {

        // For Extra Creativity: i prompted the user for a number of words they will like to hide and hid it.
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
       
        
        string text = "in the begining was the word, and the word was with God, and God was the word";
        Reference title = new Reference("John",1,1);
        Scripture scripture1 = new Scripture(title,text);
        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        string userText = "";
        while (userText != "quit" && scripture1.IsCompletelyHidden() != true)
        {
            
             Console.WriteLine("Press Enter To Continue Or 'quit' to end");
            userText = Console.ReadLine();

            if (userText != "quit")
            {
                Console.Write("How many words will you like to hide: ");
                int param = int.Parse(Console.ReadLine());
                scripture1.HideRandomWords(param);
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());
            }


            
           //  Console.WriteLine("How many words will you like to hide? ");
            // int param = int.Parse(Console.ReadLine());
            
            
            
           

            

        }
        
    }
}