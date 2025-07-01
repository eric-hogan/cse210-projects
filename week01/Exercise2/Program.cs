using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


        // Get the  grade percentage from user
        Console.Write("What is the percentage? ");
        string percentage = Console.ReadLine();
        int gradePercent = int.Parse(percentage);


        // Find the grade letter
        string letter = ("");
        if (gradePercent >= 90)
        {
            letter = ("A");
        }

        else if (gradePercent >= 80)
        {
            letter = ("B");

        }
        else if (gradePercent >= 70)
        {
            letter = ("C");

        }
        else if (gradePercent >= 60)
        {
            letter = ("D");
        }

        else
        {
            letter = ("F");
        }

        //Determine if a + or - is needed 
    
        int firstNum = int.Parse(percentage[0].ToString());
        int secondNum = int.Parse(percentage[1].ToString());
        string gradeSuffix = "";

        if (secondNum >= 7 && firstNum != 5 && firstNum != 9)
        {
            gradeSuffix = "+";
        }

        else if (secondNum <= 3 && firstNum != 5)
        {
            gradeSuffix = "-";
        }

        else
        {
            gradeSuffix = "";
        }


        // Display grade and whether or not the student passed.
        Console.WriteLine($"You final grade is a(n) {letter} {gradeSuffix}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("You have failed. Try again?");
        }

    }



    
}