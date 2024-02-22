using System;

public  class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description,int points, bool isComplete): base(name,description,points)
    {
      _isComplete = isComplete;
    }
    
    public override void RecordEvents()
    {
      _isComplete = true;//since it's a simple goal, once the user selects to record the event,
      // the task is completed.
      Console.WriteLine($"Congratulations you have earned {_points} points.");
    }

    public override int GetPoints()
    {
      return _points;
    }
    public override bool IsComplete()
    {   
      if (_isComplete == true)
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
        string goalType = "Simple Goal";
        if (IsComplete() == true)
        {
            complete = "C";
        }

        else
        {
            complete = " ";
        }


        return $"[{complete}] {goalType}: {_shortName},({_description})";
    }

    public override string GetStringRepresentation()
    {
      string goalType = "Simple Goal";
      return $"{goalType}: {_shortName},{_description},{_points},{_isComplete}";
    }
}