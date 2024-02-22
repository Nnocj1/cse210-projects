/*Author: Nicholas Oblitey Commey
Purpose: Fulfil W05 Polymorphism Assessment.
Lessons: I have learned the use of the key words virtual, abstract, and override used in applying polymorphism
Date: 22/02/2024.
Showing Creativity and exceeding requirement: I added a Display quote function to motivate users depending on their experience or expertise. */




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

