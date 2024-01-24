using System;

class Program
{
    static void Main (string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "ProQuest";
        job1._jobTitle = "Data Entry Operator";
        job1._startYear = 2022;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._companyName = "Joeracle Montessori School";
        job2._jobTitle = "Teacher";
        job2._startYear = 2018;
        job2._endYear = 2020;


        Resume myResume = new Resume();
        myResume._personName = "Nicholas Oblitey Commey";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    
    }

}