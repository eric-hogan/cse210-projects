using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)

    {
        string choice = "";
        int loops = 0;


        do
        {
            Reference r1 = new Reference("John", 3, 16);
            Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            while (!s1.IsCompletelyHidden() + choice != "quit")
            {

                if (loops == 0)
                {
                    Console.WriteLine(s1.GetDisplayText());
                    loops++;
                    Console.WriteLine("Hit enter to continue or type quit to exit out");
                    choice = Console.ReadLine();

                }

                else
                {
                    s1.HideRandomWords(2);
                    Console.WriteLine(s1.GetDisplayText());
                    Console.WriteLine("Hit enter to continue or type quit to exit out");
                    choice = Console.ReadLine();
                }
            }

            Console.WriteLine(s1.GetDisplayText());
            Console.WriteLine("Hit enter to continue or type quit to exit out");
            choice = Console.ReadLine();
        } while (choice != "quit");



    }
    
    
}