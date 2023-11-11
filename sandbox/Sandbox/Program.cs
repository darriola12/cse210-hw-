using System;
using System.Data.Common;
using System.Threading.Tasks.Dataflow;

class Program
{
   public class Job
   {
    public string _JobTitle;
    public string _company;
    public double _start_year; 
    public double _end_year;
   } 
   public class Resume
   {
    public string _name; 
    public List<Job> jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine(jobs);

    }
    
   }
}
