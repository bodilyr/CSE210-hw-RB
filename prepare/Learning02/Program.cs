using System;

class Program
{
    static void Main(string[] args) 
    {
        //create a new job instance named job1
        Job job1 = new Job();

        //set member variables using dot notation
        job1._company = "Appleton";
        job1._jobTitle = "Receptionist";
        job1._startYear = 1987;
        job1._endYear = 1988;

        //verify display of information using DisplayJobInfo()
        job1.DisplayJobInfo();

        //create a new job instance named job2
        Job job2 = new Job();

        //set member variables using dot notation
        job2._company = "West Ada School District";
        job2._jobTitle = "Administrative Assistant";
        job2._startYear = 2017;
        job2._endYear = 2024;

        //verify display of information using DisplayJobInfo()
        job2.DisplayJobInfo();

        Resume resume1 = new Resume();
        resume1._name = "Rhonda Bodily";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}