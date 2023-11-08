using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade");
        string grade_input = Console.ReadLine();
        int grade = int.Parse(grade_input);
        if (grade >= 90)  
        {
            Console.Write("Your grade is A");
        }
        else if(grade >= 80)
        {
            Console.Write("Your grade is B");
        }
        else if (grade >= 70)
        {
            Console.Write("Your grade is C");

        }
        else if (grade >= 60)
        {
            Console.Write("Your grade is D");
        }
        else
        {
            Console.Write("Your grade is F");
        }
    }
}