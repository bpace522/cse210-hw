using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Ninja";
        job1._startYear = 1834;
        job1._endYear = 1954;

        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._jobTitle = "Playtester";
        job2._startYear = 1955;
        job2._endYear = 2025;

        Resumes resume1 = new Resumes();
        resume1._name = "Bradley Pace";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}