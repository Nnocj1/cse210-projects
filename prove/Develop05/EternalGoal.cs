using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description,int points): base(name,description,points)
    {

    }
    
    public override void RecordEvents()
    {
        Console.WriteLine($"Congratulations you have earned {_points} points.");
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;// because eternal goals cannot be completed in this life.
    }

    public override string GetDetailsString()
    {   
        string complete;
        string goalType = "Eternal Goal";
        if (IsComplete() == true)
        {
            complete = "E";
        }

        else
        {
            complete = " ";
        }

        return $"[{complete}] {goalType}: {_shortName},({_description})";
    }

    public override string GetStringRepresentation()
    {
      string goalType = "Eternal Goal";
      return $"{goalType}: {_shortName},{_description},{_points}";
    }

    // Here is where i show creativity by adding motivational quotes specific to each type of goal.
    public override void DisplayMotivationalQuote()
    {
        List<string> motivations = new List<string>(){
            "The purpose of life is to discover your gift. The meaning of life is to give it away. - David Viscott",
            "Faith is taking the first step even when you don't see the whole staircase. - Martin Luther King Jr.",
            "Your work is to discover your world and then with all your heart give yourself to it. - Buddha",
            "The soul always knows what to do to heal itself. The challenge is to silence the mind. - Caroline Myss"
        };

        Random random= new Random();
        int randomIndex = random.Next(motivations.Count);
        string randomQuote = motivations[randomIndex];

        Console.WriteLine($"\n{randomQuote}\n");
    }

}