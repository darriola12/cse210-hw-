using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is the magic number?");
        string add_number =  Console.ReadLine();
        int number = int.Parse(add_number);
        Console.Write("What is your guess");
        string guess_number = Console.ReadLine();
        int change_number = int.Parse(guess_number);
        
        while (change_number != number)
        {
            if (change_number > number)
            { 
                Console.WriteLine("Lower");

            }
            if (change_number < number)
            {
                Console.WriteLine("Higher");

            }
            Console.Write("What is your guess");
            guess_number = Console.ReadLine();
            change_number = int.Parse(guess_number);
            
        }
        Console.WriteLine("that is the right one");
    }
}