using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
         

         WritingAssignment writing = new WritingAssignment("Lucian Slater","Evolution","Cognitive Revolution");
        Console.WriteLine($"{writing.GetWritingInformation()}");
    }
}