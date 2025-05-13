using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Console.WriteLine($"{job1._jobTitle} at ({job1._company}) {job1._startYear} - {job1._endYear}");

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Console.WriteLine($"{job2._jobTitle} at ({job2._company}) {job2._startYear} - {job2._endYear}");

        // Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}