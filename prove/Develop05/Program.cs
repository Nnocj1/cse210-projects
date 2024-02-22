using System;

public class Program
{
    static void Main(string[] args)
    {   
        // initializing the parameters needed for the creation of the GoalManager
        int score = 0;
        List<Goal> goals = new List<Goal>();
        GoalManager newGoalManager = new GoalManager(goals, score);
       
        while (true)
        {
            //Displaying Total points earned.
            newGoalManager.DisplayPlayerInfo();
            
            //Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals.\n 3. Save Goals.\n 4. Load Goals.\n 5. Record Event\n 6. Quit.");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            


            if (choice == 1)
            {
                newGoalManager.CreateGoal();
            }

            else if (choice == 2)
            {
                newGoalManager.ListGoalDetails();
            }

            else if (choice == 3)
            {
                newGoalManager.SaveGoals();
            }

            else if (choice == 4)
            {
                newGoalManager.LoadGoals();
            }

            else if (choice == 5)
            {
                newGoalManager.RecordEvent();
            }

            else if (choice == 6)
            {
                break;
            }
        }
    }
}

