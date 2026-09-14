// This class represents one job.
// It contains the job title, company, start year, and end year.
//Gladys Catayoc


public class Job
{
    // These variables store information about the job.
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

    // This method displays the job information.
    public void Display()
    {
        // Display the job title, company, and years.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}