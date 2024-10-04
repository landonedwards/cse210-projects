using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();

        job1._company = "Microsoft";
        job1._title = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new();

        job2._company = "Apple";
        job2._title = "Regional Manager";
        job2._startYear = 2018;
        job2._endYear = 2023;
        

        Resume resume = new();

        resume._name = "Landon Edwards";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();



    }
}