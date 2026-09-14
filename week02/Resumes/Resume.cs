// This class represents a person's resume.
// It contains the person's name and a list of their jobs.
//Gladys Catayoc

public class Resume
{
    // This variable stores the person's name.
    public string _name = "";

    // This list stores all of the person's jobs.
    public List<Job> _jobs = new List<Job>();

    // This method displays the resume.
    public void Display()
    {
        // Display the person's name.
        Console.WriteLine($"Name: {_name}");

        // Display the word Jobs.
        Console.WriteLine("Jobs:");

        // Go through each job in the list.
        foreach (Job job in _jobs)
        {
            // Display the information for each job.
            job.Display();
        }
    }
}