// This is the "Program.cs" file, which contains the main entry point for the application. It creates job objects, adds them to a resume, and displays the resume.
//This is week 2 on Resumes. In this assignment, you will create a Resume class and a Job class. The Resume class will have a list of Job objects, and the Job class will have properties for the job title, company, start year, and end year. You will then create a Resume object, add Job objects to it, and display the resume.
//Gladys Catayoc

using System;

class Program
{
    static void Main(string[] args)
    {
        // STEP 1: Create the first job.
        Job job1 = new Job();

        // Give the first job its information.
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        // STEP 2: Create the second job.
        Job job2 = new Job();

        // Give the second job its information.
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        // STEP 3: Create a Resume object.
        Resume myResume = new Resume();

        // Give the resume a person's name.
        myResume._name = "Allison Rose";


        // STEP 4: Add the first job to the resume.
        myResume._jobs.Add(job1);

        // Add the second job to the resume.
        myResume._jobs.Add(job2);


        // STEP 5: Display the entire resume.
        myResume.Display();
    }
}