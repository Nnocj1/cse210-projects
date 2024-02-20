using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description,string points): base(name,description,points)
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
        return 
    }



}