public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one good thing that happened today?", "What is something that you have been thinking about recently?", "If you could change somethihng that happened today what would it be?","Where have you seen the Lord's hand in your life today?", "What is something that you learned today?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
}