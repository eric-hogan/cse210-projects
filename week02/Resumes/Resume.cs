public class Resume()
{
    public string _firstName = ("");
    public string _lastName = ("");
    public string _email = ("");
    public string _phoneNumber = ("");
    

    public List<Job> _listOfJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");

        foreach (Job job in _listOfJobs)
        {
            job.DisplayJobInfo(); 
        }

    }
}