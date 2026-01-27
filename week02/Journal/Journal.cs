using System.IO;
using System.Text.Json;


public class Journal
{
  public List<Entry> _entries = new List<Entry> ();

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
  public void SaveToFile(string filename)
  {
    using (StreamWriter writefile = new StreamWriter(filename))
    {
      foreach (Entry e in _entries)
      {
        writefile.WriteLine(e.ForFile());
      }
    }
  }
  public void LoadFromFile(string filename)
  {
    string [] lines = System.IO.File.ReadAllLines(filename);
  
    foreach (string line in lines)
    {
      string [] parts = line.Split("*");
      string date = parts[0];
      string prompt = parts[1];
      string promptans = parts[2];

      Console.WriteLine($"{date} {prompt} {promptans}");
    };
  }
  public void SaveToJson( string filename)
  {
    string json = JsonSerializer.Serialize(_entries,new JsonSerializerOptions{WriteIndented = true});
    File.WriteAllText(filename,json);
  }
  public void ReadFromJson(string filename)
  {
   string json =  File.ReadAllText(filename);
   List<Entry> loadedj =JsonSerializer.Deserialize<List<Entry>>(json);
   foreach (Entry e in loadedj)
   {
    e.Display();
   }

  }
}