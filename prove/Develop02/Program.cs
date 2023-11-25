using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Dynamic;




class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
       string starter = "";
        while  ( starter!="6")
        {
            Console.Write("\nPlease select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\nWhat would you like to do? ");
            string option = Console.ReadLine();
            Entry entry = new Entry();
            Prompt prompt= new Prompt(); 
            Journal journal2 = new Journal();       
            if (option == "1")
            {
                string question = prompt.GetRamdon(); 
                Console.WriteLine($"{question}");
                entry._getNote = Console.ReadLine();
                entry._prompt = question;


                DateTime timenow = DateTime.Now;
                entry._todayDate = timenow.ToShortDateString();
                
                journal1.addinfo(entry);
            }
            else if(option == "2")
            {
                journal1.Display();
            }
            else if(option == "3")
            {
                List<string> readFiles = new List<string>();
                Console.WriteLine("What is the name of note you want to load?");
                journal1._filename = Console.ReadLine();
                
                string [] lines = System.IO.File.ReadAllLines(journal1._filename);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }           

            }   
            else if(option == "4")
            {
                Console.WriteLine("what is the filename");
                    journal1._filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(journal1._filename))
                    {
                        foreach(Entry file1 in journal1.listEntries)
                        {
                            outputFile.WriteLine($"\nDate: {file1._todayDate}, \nprompt: {file1._prompt}, \nNote: {file1._getNote} ");

                        }

                    }

                    
            

            }
        
            else if(option == "5")
            {
                Console.WriteLine("Vuelve pronto");
                break;

            }
            else
            {
                continue;
            }

            

        
        }
    }

}
