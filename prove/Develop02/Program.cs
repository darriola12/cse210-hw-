using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Formats.Asn1;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using System.Dynamic;



class Program
{
    static void Main(string[] args)
    {
        Journal write = new Journal();
        write._Menu = "1.Write";

        Journal display = new Journal();
        display._Menu = "2.Display";

        Journal load = new Journal();
        load._Menu = "3.Load";

        Journal save = new Journal();
        save._Menu = "4.Save";
        
        Journal quit = new Journal();
        quit._Menu = "5.Quit";

        List<Journal> prompts = new List<Journal>();

        Console.WriteLine("Welcome to your Journal, here some options:");

        

        List<Journal> Menu = new List<Journal>();
        Menu.Add(write);
        Menu.Add(display);
        Menu.Add(load);
        Menu.Add(save);
        Menu.Add(quit);

        foreach(Journal i in Menu)
        {
            Console.WriteLine(i._Menu);
        }

        Console.WriteLine("What would you like to do?");
        String getAnswer = Console.ReadLine(); 

        if (getAnswer == "1")
        {
            Console.WriteLine("Who was the most interesting person I interacted with today?");
            string get_annwer1 = Console.ReadLine();
            

        }
        
        

    
  
    }

    public static void  SaveFile(List<Journal> Menu)
    {
        string filename = "notes.txt";
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Journal p in Menu)
            {
                outputFile.WriteLine(p._Menu);
            }

        }
    }  

    
        
    }

}
