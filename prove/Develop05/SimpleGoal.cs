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

    public override void DisplayMotivationalQuote()
    {
        List<string> motivations = new List<string>(){
          "The expert in anything was once a beginner. - Helen Hayes",
          "Success is not the key to happiness. Happiness is the key to success.\nIf you love what you are doing, you will be successful.  - Albert Schweitzer",
          "You don't have to be great to start, but you have to start to be great. - Zig Ziglar",
          "The journey of a thousand miles begins with one step. - Lao Tzu"
        };

        Random random= new Random();
        int randomIndex = random.Next(motivations.Count);
        string randomQuote = motivations[randomIndex];

        Console.WriteLine($"\n{randomQuote}\n");
    }
}