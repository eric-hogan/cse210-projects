public class ReflectionActivity : Activity
{
    //All prompts and questions were taken from the CSE210 Mindfulness program instrucitons
    List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};

    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" 
};

    public ReflectionActivity()
    {
        _name = "Reflection activity";
        _description = "In this activity you will be given a random prompt pertaining to an experience that you have had. After you come up with the experience, you will then be asked a series of questions about that experience.";
    }


    public void Run()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        DisplayPrompt();

        int i = 0;
        while (DateTime.Now < endTime)
        {
                DisplayQuestion();
                ShowCountDown(5);
                i++;
                Console.Clear();
                if (i == _questions.Count)
                {
                    endTime = DateTime.Now;
                }
 
        }
    }

    //Stores the list of prompts and then retrieves a random prompt to be used by the DisplayPrompt method.
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        return prompt;
    }

    //Displays a random prompt by using the GetRandomPrompt method.
    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }


    //Returns a random string. 
    private string GetRandomQuestion()
    {

        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string question = _questions[randomIndex];

        return question;
    }

    //Retrieves a random question by calling the GetRandomQuestion function. 
    private void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"{question} ");
    }


}