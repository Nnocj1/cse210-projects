using System;


public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public CheckListGoal(string name, string description, string point, int target, int bonus): base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvents()
    {

    }
   
    public override bool IsComplete()
    {
        return
    }

    public override string GetDetailsString()
    {
        return
    }

    public override string GetStringRepresentation()
    {
        return
    }
}