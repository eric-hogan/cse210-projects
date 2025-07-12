using System;

class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._yearStart = "2021";
        job1._yearEnd = "2027";


        // job1.DisplayJobInfo();

        Job job2 = new Job();
        job2._jobTitle = "Teacher";
        job2._company = "Flathead";
        job2._yearStart = "2015";
        job2._yearEnd = "2020";

        // job2.DisplayJobInfo();

        Resume myResume = new Resume();
        myResume._firstName = "Eric";
        myResume._lastName = "Hogan";
        myResume._listOfJobs.Add(job1);
        myResume._listOfJobs.Add(job2);


        // Console.WriteLine ($"{myResume._listOfJobs[0]._jobTitle}");

        myResume.DisplayResume();

    }
}