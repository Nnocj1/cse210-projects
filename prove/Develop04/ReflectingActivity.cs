using System;

public class ReflectingActivity: Activity
{
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
                Console.WriteLine($" ----{GetRandomPrompt()} ---- ");
                Console.WriteLine("When you have something in mind, press enter to continue");
                Console.ReadLine();
                
                Console.WriteLine("Now ponder on each of the following questions, as they are related to this experience");
                Console.Write("You may begin in:"); ShowCountDown();
                DisplayQuestion(); ShowSpinner();

                Console.WriteLine("\n");
            }

            DisplayEndingMessage();
        }
    }

    public string GetRandomPrompt()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            };
                    
            //a random object for generating random prompts
            Random random = new Random();

            int randomIndex = random.Next(prompts.Length);
            string randomPrompt = prompts[randomIndex];

            
            return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        string[] prompts = {
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
                    
            //a random object for generating random prompts
            Random random = new Random();

            int randomIndex = random.Next(prompts.Length);
            string randomQuestion = prompts[randomIndex];

            return randomQuestion;
            
    }

    public void DisplayPrompt()
    {   //display a random prompt
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        //display a random question for the user to enter details
        Console.Write(GetRandomQuestion());
    }

 }