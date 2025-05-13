// calling the system method

using System;

public class Job
{
    // these lines of code are used to declare the variables as global variables to be used anywhere in the program
    // this line of code is used to create a class called Job
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // public Job(string jobTitle, string company, int startYear, int endYear)
    // {
    //     _jobTitle = jobTitle;
    //     _company = company;
    //     _startYear = startYear;
    //     _endYear = endYear;
    // }

    // this line of code is used to create a constructor that takes in the parameters jobTitle, company, startYear, and endYear
    // public Job(string jobTitle, string company, int startYear, int endYear)

    // Job job = new Job("Software Engineer", "Tech Corp", 2015, 2020);

    // this line of code is used to create a method that displays the job information
    public void DisplayJob()

    {
        Console.WriteLine($"{_jobTitle} at ({_company}) {_startYear} - {_endYear}");
    }
}