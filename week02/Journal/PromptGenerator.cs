public class PromptGenerator
{
   public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        Random random = new Random();
       int randomIndex = random.Next(_prompts.Count());
       return _prompts[randomIndex];
    }
}