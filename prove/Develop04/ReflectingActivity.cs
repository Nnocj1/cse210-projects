using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity()
    {

    }

    public void Run()
    {

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

            //display a random prompt for the user to enter details
            Console.Write(randomPrompt);
        }

    public string GetRandomQuestions()
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

            //display a random prompt for the user to enter details
            Console.Write(randomQuestion);
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }

}