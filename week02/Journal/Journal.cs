using System.IO;
using System.Text.Json;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
      foreach (Entry e in _entries)
      {
        e.Display();
      }
    }
    public void SaveToFile(string file)
    {
        using(StreamWriter outputfile = new StreamWriter(file))
      {
      foreach (Entry e in _entries)
      {
        outputfile.WriteLine(e.ForFile());
         
      }
     }

    }
    public void LoadFromFile(string file)
    {
     string [] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
          string [] part = line.Split("]");
        // Date: 1/18/2026,]-Prompt:] What was the best part of my day? : ]cryptic ]
          string date = part[0];
          string prompt = part[1];
          string response = part[2];
         
        Console.WriteLine($"{date} {prompt} {response} ");
        }
       // 
       //  string date = line
    }
    public void SaveToJson(string filename)
  {
    string toJson = JsonSerializer.Serialize(_entries,new JsonSerializerOptions {WriteIndented = true} );
    File.WriteAllText(filename,toJson);
      
    
  }
  public void ReadFromJson(string filename)
  {
    string reverse = File.ReadAllText(filename);
    List<Entry> loadedjson = JsonSerializer.Deserialize<List<Entry>>(reverse);
     foreach (Entry item in loadedjson)
     {
      item.Display();
     }
    
  }
}