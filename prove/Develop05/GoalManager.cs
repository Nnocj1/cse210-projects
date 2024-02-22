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

    public int GetScore()
    {
        return _score;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {   
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {index}. {goal.GetDetailsString()}");
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
                string userPoints = Console.ReadLine();
                int goalPoints = int.Parse(userPoints);
                bool isComplete = false;

                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, isComplete);
                _goals.Add(newSimpleGoal);

            }

            else if (goal == 2)
            {
                Console.Write("What is the name of your goal?: ");
                string goalName = Console.ReadLine();

                Console.Write("Describe your goal?: ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points should you earn once you complete this goal?: ");
                string userPoints = Console.ReadLine();
                int goalPoints = int.Parse(userPoints);

                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(newEternalGoal );
            }

            else if (goal == 3)
            {
                Console.Write("What is the name of your goal?: ");
                string goalName = Console.ReadLine();

                Console.Write("Describe your goal?: ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points should you earn once you complete this goal?: ");
                string userPoints = Console.ReadLine();
                int goalPoints = int.Parse(userPoints);

                Console.Write("How many times must this goal be accomplished?: ");
                string userTarget = Console.ReadLine();
                int goalTarget = int.Parse(userTarget);

                Console.Write("What will be the bonus once the task is accomplished?: ");
                string userBonus = Console.ReadLine();
                int goalBonus = int.Parse(userBonus);
                int amountCompleted = 0;
                CheckListGoal newCheckListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus, amountCompleted);
                _goals.Add(newCheckListGoal);
            }

            else
            {
              Console.WriteLine("You entered an Invalid number.");
            }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalDetails();
        Console.WriteLine("Which goal did you accomplish?:");
        string userAccomplishment = Console.ReadLine();
        int accomplishedGoalIndex = int.Parse(userAccomplishment) -1;

        if (accomplishedGoalIndex  >= 0 && accomplishedGoalIndex < _goals.Count)
        {
            _goals[accomplishedGoalIndex].RecordEvents(); // Call RecordEvents of the selected goal
            _score += _goals[accomplishedGoalIndex].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal selection!");
        }
            

    }

    public void SaveGoals()
    {   
        Console.WriteLine("What is the name of the file to save your goals?:");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            outputFile.WriteLine($"score: {_score}");
            //outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                
            }
            Console.WriteLine("New Goals saved!\n");
        }
    }

    public void LoadGoals()// there are different ways to achieve this.  either say while not end of stream, or use a foreach loop.
    {
        Console.WriteLine("What is the filename for your goals?:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] space = line.Split(" ");
                if (space.Length < 3)
                {
                    _score = int.Parse(space[1]);
                }
                
                

                else
                {
                    string[] parts = line.Split(":");
                    //string goalType = parts[0];
                    string remainingInfo= parts[1];
                    string[] partsB = remainingInfo.Split(",");
                    string shortname = partsB[0];
                    string description= partsB[1];

                    int points = int.Parse(partsB[2]);


                    if (partsB.Length == 6)
                    {
                        int bonus = int.Parse(partsB[3]);
                        
                        int target = int.Parse(partsB[4]);

                        int amountCompleted = int.Parse(partsB[5]);

                        CheckListGoal checkListGoal = new CheckListGoal(shortname, description, points, target, bonus, amountCompleted);
                    
                        _goals.Add(checkListGoal);

                    }   

                    else if (partsB.Length == 3)
                    {
                        EternalGoal eternalGoal = new EternalGoal(shortname, description, points);
                        _goals.Add(eternalGoal);
                    }
                    
                    else if (partsB.Length == 4)
                    {
                        bool completed = bool.Parse(partsB[3]);

                        SimpleGoal simpleGoal = new SimpleGoal(shortname, description, points, completed);
                        _goals.Add(simpleGoal);
                    }  
                    
                }
                
            }
            Console.WriteLine("Goals has been loaded successfully!\n");
            
        }
    }
}
