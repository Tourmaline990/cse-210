public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public  string GetRandomPrompts()
    {
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);

        string randomprompt = _prompts[randomIndex];

        
        return randomprompt;
    }
}