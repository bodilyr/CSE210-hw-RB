using System;

public class Job
{
    //define member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    
//method that displays the job information
    public void DisplayJobInfo()
    {
        Console.WriteLine ($"{_jobTitle } ({_company }) {_startYear}-{_endYear}");
    }

    
}