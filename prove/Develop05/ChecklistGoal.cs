using System;


public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public CheckListGoal(string name, string description, int point, int target, int bonus, int amountCompleted): base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvents()
    {
        _amountCompleted += 1;
        if (IsComplete() == true)
        { 
            
            Console.WriteLine($"Congratulations you've earned {_bonus} points");
        }

        else
        {
           Console.WriteLine($"Congratulations you have earned {_points} points.");
        }
        
    }
   
   public override int GetPoints()
   {
    return _points;
   }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string complete;
        string goalType = "ChecklistGoal";
        if (IsComplete() == true)
        {
            complete = "C";
        }

        else
        {
            complete = " ";
        }

        return $"[{complete}] {goalType}: {_shortName}({_description})--- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() 
    {    
        string goalType = "Checklist Goal";
        return $"{goalType}: {_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override void DisplayMotivationalQuote()
    {
        List<string> motivations = new List<string>(){
            "You're never a loser until you quit trying. - Mike Ditka",
            "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
            "You are never too old to set another goal or to dream a new dream. - C.S. Lewis",
            "Success is the sum of small efforts, repeated day in and day out. - Robert Collier"
        };

        Random random= new Random();
        int randomIndex = random.Next(motivations.Count);
        string randomQuote = motivations[randomIndex];

        Console.WriteLine($"\n{randomQuote}\n");
    }
}