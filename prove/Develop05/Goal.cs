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

    public abstract void RecordEvents();
    
   
    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
         return $"{_shortName},{_description},{_points}";
    }

    public abstract string GetStringRepresentation();
    
    // Here is where i show creativity by adding motivational quotes specific to each type of goal.
    public abstract void DisplayMotivationalQuote();
    

}