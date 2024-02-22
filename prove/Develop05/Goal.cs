using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string shortname, string description, int points)
    {
        _shortName = shortname;
        _description = description;
        _points = points;

       
    }
    
    public string GetGoalName()
    {
       return _shortName;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvents()
    {   
      Console.WriteLine($"Congratulations you have earned {_points} points.");
    }
   
    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
         return $"{_shortName},{_description},{_points}";
    }

    public abstract string GetStringRepresentation();
    
    
}