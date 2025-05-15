using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Analyst";
        job1._company = "Disney";
        job1._startYear = 2006;
        job1._endYear = 2011;

        Job job2 = new Job();
        job2._jobTitle = "Sandwich Artist";
        job2._company = "Subway";
        job2._startYear = 2011;
        job2._endYear = 2013;

        Job job3 = new Job();
        job3._jobTitle = "Professor";
        job3._company = "Hogwarts";
        job3._startYear = 2014;
        job3._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "John Smith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}