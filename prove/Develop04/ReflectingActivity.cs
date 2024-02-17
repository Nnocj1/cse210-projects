using System;

public class ReflectingActivity: Activity
{
    //variables
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //methods
    public ReflectingActivity(string name, string activityInfo): base(name, activityInfo)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        // Record the starting time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
     
        {
            while(DateTime.Now < endTime)
            {
                Console.WriteLine("Consider the following prompt....");
                DisplayPrompt();
                Console.WriteLine("When you have something in mind, press enter to continue");
                Console.ReadLine();
                
                Console.WriteLine("Now ponder on each of the following questions, as they are related to this experience");
                Console.Write("You may begin in:"); ShowCountDown(5);
                DisplayQuestion(); ShowSpinner(5);

                Console.WriteLine("\n");
            }

            DisplayEndingMessage();
        }
    }

    public string GetRandomPrompt()
    {
        //a random object for generating random prompts
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
  
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {   
        //a random object for generating random prompts
        Random random = new Random();

        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];

        return randomQuestion;
            
    }

    public void DisplayPrompt()
    {   //display a random prompt
        Console.WriteLine($" ----{GetRandomPrompt()} ---- ");
    }

    public void DisplayQuestion()
    {
        //display a random question for the user to enter details
        Console.Write(GetRandomQuestion());
    }
}