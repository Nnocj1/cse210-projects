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
}