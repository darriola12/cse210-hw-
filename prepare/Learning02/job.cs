
public class Job
   {
    public string _JobTitle;
    public string _company;
    public double _start_year; 
    public double _end_year;

    public void Display()
    {
        Console.WriteLine($"{_JobTitle} ({_company}) {_start_year} - {_end_year}");
    }
   } 
public class Resume
{
    public string _Name; 
    public List<Job> _Jobs = new List<Job>();

    public void Display_Resume()
    {
        Console.WriteLine($"Nmae:{_Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _Jobs)
        {
            job.Display();
        }

    }

}