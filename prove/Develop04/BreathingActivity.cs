using System;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    { //Place the variables in the Activity class.
    
    }

    public void Run()
    {
        DisplayStartingMessage();// Place  it here so that duration will obtain it value directly from this
        Console.WriteLine(" ");
        // Record the starting time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
     
        {
            while(DateTime.Now < endTime)
            {
                Console.Write("Breathe in...");
                ShowCountDown(5);
                
                if (DateTime.Now >= endTime)              
                    break;
               

                Console.Write("Breathe out...");
                ShowCountDown(5);

                if (DateTime.Now >= endTime)
                    break;
                
                

                Console.WriteLine(" ");
            }
           
        }  
        DisplayEndingMessage();
    } 
}