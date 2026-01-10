using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int largest = 0;
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int sum = 0;
        int count = 0;
        int userNum = -1;
        while (userNum != 0)
        {
           Console.Write("Enter number: ");
           userNum = int.Parse(Console.ReadLine());
           numbers.Add(userNum);
           sum += userNum;
           count ++;
           if(userNum > largest)
            {
                largest = userNum;
            }
        }
       
        Console.WriteLine($"The sum is: {sum}");
        int countMod = count - 1;
        float avg = ((float)sum) / countMod;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest is: {largest}");

    
}

}