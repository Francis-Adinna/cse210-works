using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        int suffixGrade = grade % 10;
        string suffix = "";
        if (grade >= 90)
        {
           letter = "A";
        }
        else if(grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (suffixGrade >= 7 && !(letter == "A" || letter == "F"))
        {
            suffix = "+";
        }
        else if (suffixGrade < 3 && !(letter == "F"))
        {
            suffix = "-";
        }
        else
        {
            suffix = "";
        }

        Console.WriteLine($"You've got a {letter}{suffix}!");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you also passed the course.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Sorry you did not pass the course.");
        }
    }
    
}