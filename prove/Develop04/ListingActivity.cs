using System;


public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description): base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        GetListFromUser();
        Console.WriteLine($"You have added {_count} items to the list.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
                 
        //a Random object for generating random prompts
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        // Display a random prompt for the user to enter details
        Console.Write($"----{randomPrompt}----");
    }

   public List<string>GetListFromUser()
   {
       List<string> items = new List<string>();

       Console.WriteLine("\nList as many responses as you can from the following prompts");
       GetRandomPrompt();
       Console.Write("You have: ");
       ShowCountDown(3);

       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(GetDuration());
     

        while (DateTime.Now < endTime)
        {
            {
                if (DateTime.Now == endTime)
                {
                    break;
                }

                else
                {
                    string item = Console.ReadLine();
                    items.Add(item);
                    _count += 1;
                }
            }
            
        }
        return items;
             
   }

}

