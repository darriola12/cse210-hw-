using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished");
        

        List<int> number_list = new List<int>();
        while (true)
        {
            Console.WriteLine("enter the number");
            int changed_number1 = int.Parse(Console.ReadLine());

            if (changed_number1 == 0)
            {
                break;
            }
            number_list.Add(changed_number1);

        }
        int sum_list = number_list.Sum();
        int max_list = number_list.Max();
        double average_list  = number_list.Average();
        

        Console.WriteLine(sum_list);
        Console.WriteLine(max_list);
        Console.WriteLine(average_list);
        









        

        






    }
}