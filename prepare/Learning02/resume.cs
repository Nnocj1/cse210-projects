using System;


public class Resume
{
  //keep track of the person's name and jobs
  public string _personName;
  public List<Job>_jobs = new List<Job>(); //initializing new list for use.

  //displaying resume
  public void Display()
  {
    Console.WriteLine($"Name: {_personName}");
    Console.WriteLine("Jobs:");

    //looping through each job in the list to display
    foreach (Job job in _jobs)
    {
        job.Display();
    }
  }
 
}
