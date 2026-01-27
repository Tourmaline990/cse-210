using System.Text.Json.Serialization;

public class Entry
{
  [JsonInclude]public string _date;
  [JsonInclude]public string _promptText;
  [JsonInclude]public string _entryText;


  public void Display()
   {
      Console.WriteLine($"{_date} {_promptText} {_entryText} ");
   }
   public string ForFile()
   {
      return $"{_date}*{_promptText}*{_entryText} ";
   }

}