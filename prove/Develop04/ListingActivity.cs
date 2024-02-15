using System;


public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
 
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            };
                    
            //a random object for generating random prompts
            Random random = new Random();

            int randomIndex = random.Next(prompts.Length);
            string randomPrompt = prompts[randomIndex];

            //display a random prompt for the user to enter details
            Console.Write(randomPrompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
    }

}

