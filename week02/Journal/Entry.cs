using System.Text.Json.Serialization;

public class Entry
{
   [JsonInclude] public string _date;
   [JsonInclude]  public string _promptText;

   [JsonInclude]  public string _entryText;

    public void Display()
    {
       Console.WriteLine($"Date: {_date}, -Prompt: {_promptText}, {_entryText}");
    }

    public string ForFile()
    {
       return $"Date: {_date},] -Prompt:{_promptText}:]{_entryText}]";
    }
}