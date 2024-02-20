using System;


public  class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    public Goal(string shortname, string description, string points)
    {
        _shortName = shortname;
        _description = description;
        _points = points;

       
    }
    
    public string GetName()
    {
        return _shortName;
    }

    public virtual void RecordEvents()
    {

    }
   
    public virtual bool IsComplete()
    {
        return
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}.";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}";
    }
    
}