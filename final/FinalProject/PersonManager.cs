using System;
using System.IO;

public class PersonManager
{
    private List<Person> _persons = new List<Person>();

    private int _score;

    public PersonManager(List<Person> goals, int score)
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
        while (true)
        {
            //Displaying Total points earned.
            DisplayPlayerInfo();
            
            //Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals.\n 3. Save Goals.\n 4. Load Goals.\n 5. Record Event\n 6. Quit.");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            


            if (choice == 1)
            {
                CreateGoal();
            }

            else if (choice == 2)
            {
                ListGoalDetails();
            }

            else if (choice == 3)
            {
                SaveGoals();
            }

            else if (choice == 4)
            {
                LoadGoals();
            }

            else if (choice == 5)
            {
                RecordEvent();
            }

            else if (choice == 6)
            {
                break;
            }
        }
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
    
    public void CreatePerson()
    {
        Console.WriteLine("The school is made of three types of Persons:");
        Console.WriteLine(" 1. Student.\n 2. Teacher.\n 3. Non - Teaching Staff.");
        Console.Write("What type of Person would you like to create?: ");
        string userPerson = Console.ReadLine();
        int person = int.Parse(userPerson);
            

            if (person <= 3)
            {   
                Console.Write("What is the person's Sir name?: ");
                string personLastName = Console.ReadLine();

                Console.Write("First name?: ");
                string personFirstName = Console.ReadLine();

                Console.Write("Other name/s?: ");
                string personOtherNames = Console.ReadLine();

                Console.Write("Age?: ");
                string age= Console.ReadLine();
                int personAge = int.Parse(age);
                
                if (person == 1)
                {
                    Student newStudent = new Student(personLastName, personFirstName, personOtherNames, personAge, "Enter Later", "Lydia", "Enter Later", "Enter Later", "Enter Later", false);
                    _persons.Add(newStudent);
                }

                else if (person == 2)
                {
                    Teacher newTeacher = new Teacher(personLastName, personFirstName, personOtherNames, personAge, "Enter Later", "Lydia", "Enter Later", "Enter Later", "Enter Later", false);
                    _persons.Add(newTeacher);
                }

                else if (person == 3)
                {
                    NonTeachingStaff newNonTeachingStaff = new NonTeachingStaff(personLastName, personFirstName, personOtherNames, personAge, "Enter Later", "Lydia", "Enter Later", "Enter Later", "Enter Later", false);
                    _persons.Add(newNonTeachingStaff);
                }
            }

            else
            {
            Console.WriteLine("You entered an Invalid number.");
            }
    }

    public void RecordAttendance()
    {
        Console.WriteLine("The school members are: ");
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
