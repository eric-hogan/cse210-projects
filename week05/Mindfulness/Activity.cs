using System.ComponentModel.DataAnnotations;

public class Activity
{
    public string _name;
    public string _description;
    public int _duration;


    // Constructor for Activity should not contain in parameters
    public Activity()
    {
    }


    // DisplayStart should show the user information about the activity and allow for them to enter in the amount of time that they would like to spend doing the activity. 
    public void DisplayStart()
    {
        Console.WriteLine($"Your {_name} will begin soon");
        Console.WriteLine($"Description: {_description}");
        Console.Write("Please enter the length of time (in seconds) that you like to do this activity: ");
        string timeAsString = Console.ReadLine();
        _duration = int.Parse(timeAsString);
        Console.Clear();
    }

    //DisplayEnd will show the user a message congratulating them on completing the activity
    public void DisplayEnd()
    {
        Console.WriteLine($"Great job! You completed the {_name}");
    }


    //ShowSpiner will provide a spinner to show a loading screen
    public void ShowSpinner(int seconds)
    {
        List<string> animationItems = new List<string>();
        animationItems.Add("|");
        animationItems.Add("/");
        animationItems.Add("-");
        animationItems.Add("\\");
        animationItems.Add("|");
        animationItems.Add("/");
        animationItems.Add("-");
        animationItems.Add("\\");

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationItems[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationItems.Count)
            {
                i = 0;
            }
        }

    }


    //Has a countdown timer that will go down from a predetermind time. 
    public void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
        }
    }

}