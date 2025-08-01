public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _description = "During this activity you will be focusing on your breathing. Follow the prompts to breathe at the pace of the prompts";
        _name = "Breathing activity";
    }

    public void Run()
    {
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        List<string> breathePrompts = new List<string>();
        breathePrompts.Add("Breathe in");
        breathePrompts.Add("Breathe Out");

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string breath = breathePrompts[i];
            Console.Write($"{breath}...") ;
            ShowCountDown(5);
            i++;
            Console.Clear();

            if (i >= 2)
            {
                i = 0;
            }

        }
        
    }

}