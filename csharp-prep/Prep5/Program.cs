using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squared = SquareNumber(usernumber);
        DisplayResult(username,squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }

    static int SquareNumber(int usernumber)
    {
        int squared = usernumber * usernumber;
        return squared;
    }

    static void DisplayResult(string username, int squared)
    {
       
        Console.WriteLine($"{username}, the square of your number is {squared}.");
    }
}