using System;

public class Program
{
    static void Main(string[] args)
    {   
        // initializing the parameters needed for the creation of the GoalManager
        int score = 0;
        List<Goal> goals = new List<Goal>();
        GoalManager newGoalManager = new GoalManager(goals, score);

        newGoalManager.Start();
    
    }
}

