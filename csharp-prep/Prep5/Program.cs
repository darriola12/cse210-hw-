using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        display_message();
        string username  = get_name();
        int usernumber = get_number();
        int squarenumber = square_operation(usernumber);
        Console.WriteLine($"Brother {username}, the square of your number is {squarenumber}");


    }
       static void display_message()
       {    
        Console.WriteLine("Welcome to the program!");
       }
       static string get_name()
       {
        Console.WriteLine("Please enter your name:");
         string  get_name1 = Console.ReadLine();

         return get_name1;
       }
       static int get_number()
       {
        Console.WriteLine("Please enter your favorite number: ");
        int changed_number = int.Parse(Console.ReadLine());

        return changed_number;

       }
       static int square_operation(int changed_number)
       {
         int result = changed_number * changed_number;
         return result;

       }

    
}