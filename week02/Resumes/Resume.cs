using System;

public class Resume
{
    // these lines of code are used to declare the variables as global variables to be used anywhere in the program
    // this line of code is used to create a class called Resume

    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // this line of code is used to create a method that displays the resume information
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}