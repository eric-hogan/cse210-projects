public class Job
{
    public string _jobTitle = ("");
    public string _company = ("");
    public string _yearStart = ("");
    public string _yearEnd = ("");


    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_yearStart} - {_yearEnd}");
    }
}