using System;

public  class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description,string points): base(name,description,points)
    {

    }
    
    public override void RecordEvents()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()}:{description}:{_points}";
    }



}