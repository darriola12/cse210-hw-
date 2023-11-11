using System;

class Program
{
    static void Main(string[] args)
    {
            Job job1 = new Job();
            job1._JobTitle = "Software Engineering";
            job1._company = "Microsft";
            job1._start_year = 2010;
            job1._end_year = 2019;

            Job job2 = new Job();
            job2._JobTitle = "Manager";
            job2._company = "MCM";
            job2._start_year = 2010;
            job2._end_year = 2020;

            Resume resume1 = new Resume();
            resume1._Name = "Sofia Chaverria";
            resume1._Jobs.Add(job1);
            resume1._Jobs.Add(job2);   

            resume1.Display_Resume();
            

    }
}