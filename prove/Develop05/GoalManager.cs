using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {   
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("The type of goals are:");
        Console.WriteLine(" 1. Simple Goal.\n 2. Eternal Goal.\n 3. Checklist Goal.");
        Console.Write("What type of Goal would you like to create?: ");
        string userGoal = Console.ReadLine();
        int goal = int.Parse(userGoal);
            

            if (goal == 1)
            {   
                Console.Write("What is the name of your goal?: ");
                string goalName = Console.ReadLine();

                Console.Write("Describe your goal?: ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points should you earn once you complete this goal?: ");
                string goalPoints = Console.ReadLine();

                SimpleGoal simpleGoal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(simpleGoal1);

            }

            else if (goal == 2)
            {
                Console.Write("What is the name of your goal?: ");
                string goalName = Console.ReadLine();

                Console.Write("Describe your goal?: ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points should you earn once you complete this goal?: ");
                string goalPoints = Console.ReadLine();
                EternalGoal simpleGoal2 = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(simpleGoal2);
            }

            else if (goal == 3)
            {
                Console.Write("What is the name of your goal?: ");
                string goalName = Console.ReadLine();

                Console.Write("Describe your goal?: ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points should you earn once you complete this goal?: ");
                string goalPoints = Console.ReadLine();

                Console.Write("How many times must this goal be accomplished?: ");
                string goalTarget = Console.ReadLine();
                int userTarget = int.Parse(goalTarget);
                CheckListGoal simpleGoal3 = new CheckListGoal(goalName, goalDescription, goalPoints, userTarget, userTarget);
                _goals.Add(simpleGoal3);
            }

            else
            {
              Console.WriteLine("You entered an Invalid number.");
            }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            
            foreach(Goal goal in _goals)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                
            }
        }
    }

    public void LoadGoals()// there are different ways to achieve this.  either say while not end of stream, or use a foreach llop.
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string shortname = parts[0];
            string description = parts[1];
            string point = parts[2];
            Goal goal = new Goal(shortname, description,point);
            _goals.Add(goal);
        }
    }

}
