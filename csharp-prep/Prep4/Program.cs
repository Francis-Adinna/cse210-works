using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int usernumber = 0;
        int sum = 0;
        do
        {
            Console.Write("Enter a number: ");
            usernumber = int.Parse(Console.ReadLine());
            numbers.Add(usernumber);
        }while (usernumber != 0);

        numbers.Sort();
        int largestNum = numbers[0];
        int smallestNum = int.MaxValue;
        foreach (var number in numbers)
        {
            sum+= number;
            if (number > largestNum)
            {
                largestNum = number;
            }
            if(number>0 && number<smallestNum)
            {
                smallestNum = number;
            }
        }
        int avg = sum/(numbers.Count);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine($"The sorted list is: ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}