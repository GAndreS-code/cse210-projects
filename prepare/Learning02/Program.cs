using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Amazon";
        job2._startYear = 2023;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();
    }
}