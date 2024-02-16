using System;


public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    { //Place the variables in the Activity class.
    
    }

    public void Run()
    {
        DisplayStartingMessage();// Place  it here so that duration will obtain it value directly from this
        
        // Record the starting time
        DateTime startTime = DateTime.Now;
     
        {
            while(DateTime.Now - startTime <  TimeSpan.FromSeconds(GetDuration()))
            {
                Console.Write("Breathe in...");
                ShowCountDown();
                
                Thread.Sleep(1000); // Wait for 1 second
                Console.Write("Breathe out...");
                ShowCountDown();
                Thread.Sleep(1000); // Wait for 1 second
            }
           
        }  
        DisplayEndingMessage();
    } 
}