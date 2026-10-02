using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public double _startYear;
    public double _endYear;

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"{_company} {_jobTitle} {_startYear} {_endYear}");
    }
}