using System;
using System.IO;

public class SchoolManager
{
    private List<Person> _persons = new List<Person>();

    public SchoolManager(List<Person> persons )
    {
        _persons = persons;
    }


    public void Start()
    {
        while (true)
        {
           
            
            //Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Person\n 2. List People.\n 3. Save People.\n 4. Load People.\n 5. Quit.");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            


            if (choice == 1)
            {
                CreatePerson(); //Add student with  subject info, teacher, or non-teaching staff.
            }

            else if (choice == 2)
            {
                ListPersonDetails();/// just to let's say view all information about a teacher
            }

            else if (choice == 3)
            {
                SavePeople();
            }

            else if (choice == 4)
            {
                LoadPeople();
            }

            // else if (choice == 5)
            // {
            //     RecordStudentExams();
            // }

            // else if (choice == 6)
            // {
            //     RecordStudentTest();
            // }

            // else if (choice == 7)
            // {
            //     DisplayStudentSubject();
            // }

            else if (choice == 5)
            {
                break;
            }
        }
    }

   
    public void ListPersonNames()
    {   
        int index = 1;
        foreach (Person person in _persons)
        {
            Console.WriteLine($"{index}. {person.GetOfficialName()}");
        }
    }

    public void ListPersonDetails()
    {
        int index = 1;
        foreach (Person person in _persons)
        {
            Console.WriteLine($" {index}. {person.GetPersonDetailsString()}");
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

                Console.Write("ID: ");
                string id = Console.ReadLine();

                Console.Write("Age?: ");
                string age= Console.ReadLine();
                int personAge = int.Parse(age);
                
                if (person == 1)
                {
                    // Prompt for additional information related to student
                    Console.WriteLine("Enter the number of subjects the student is studying:");
                    int numSubjects = int.Parse(Console.ReadLine());

                    // Create a new student object
                    Student newStudent = new Student(id,personLastName, personFirstName, personOtherNames, personAge, "Enter Later", "Enter Later", "Enter Later", "Enter Later", "Enter Later", false);
                    
                    //Add a subject
                    for (int i = 0; i < numSubjects; i++)
                    {
                        Console.Write($"1. Maths or 2. English?: {i + 1}: ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            newStudent.GetSubjects().Add(new MathsSubject(0, 0, 4, 25, 0, "IP"));
                        }

                        else if (choice == 2)
                        {
                            newStudent.GetSubjects().Add(new EnglishSubject(0, 0, 4, 25, 0, "IP"));
                        }
                    }

                    // Add the student to the list of persons
                    _persons.Add(newStudent);
                }

                else if (person == 2)
                {
                    Console.Write("What subject do you teach?: ");
                    string teachingSubject = Console.ReadLine();
                    Teacher newTeacher = new Teacher(id,personLastName, personFirstName, personOtherNames, personAge, teachingSubject, "Enter Later", "Enter Later", "Enter Later", "Enter Later", "Enter Later", false);
                    _persons.Add(newTeacher);
                }

                else if (person == 3)
                {
                    Console.Write("What is your role?: ");
                    string role = Console.ReadLine();
                    NonTeachingStaff newNonTeachingStaff = new NonTeachingStaff(id,personLastName, personFirstName, personOtherNames, personAge, role,"Enter Later", "Enter Later", "Enter Later", "Enter Later", "Enter Later", false);
                    _persons.Add(newNonTeachingStaff);
                }
            }

            else
            {
            Console.WriteLine("You entered an Invalid number.");
            }
    }
            

    public void SavePeople()
    {   
        Console.WriteLine("What is the name of the file to save your goals?:");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
          
            foreach(Person person in _persons)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{person.GetPersonStringRepresentation()}");
                
            }
            Console.WriteLine("Saved!\n");
        }
    }

    public List<Subject> GetStudentSubjects(Student student)
    {
        if (student != null)
        {
            return student.GetSubjects();
        }
        return null;
    }

    public void LoadPeople()// there are different ways to achieve this.  either say while not end of stream, or use a foreach loop.
    {
        Console.WriteLine("What is the filename for your goals?:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _persons.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                
                
                


            }
            Console.WriteLine("Goals has been loaded successfully!\n");
            
        }
    }
}
