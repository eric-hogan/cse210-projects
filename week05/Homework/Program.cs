using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("joe", "cheese");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Stevie Wonder", "Triangles", "99.0", "1-100");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WrittingAssignment w1 = new WrittingAssignment("Eric", "Cold War", "Impact of the Cold War on US policy");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWrittingInfo());
    }
}