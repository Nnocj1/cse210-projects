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
}