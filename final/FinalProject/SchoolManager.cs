using System;
using System.IO;

public class SchoolManager
{
    private List<Person> _persons = new List<Person>();
    private List<Student> _students = new List<Student>();
    private List<Teacher> _teachers =  new List<Teacher>();
    private List<NonTeachingStaff> _nonTeachingStaff = new List<NonTeachingStaff>();
    public SchoolManager(List<Person> persons,List<Student>students,List<Teacher> teachers,List<NonTeachingStaff> nonTeachingStaff)
    {
        _persons = persons;
        _students = students;
        _teachers = teachers;
        _nonTeachingStaff = nonTeachingStaff;

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
        Console.WriteLine("These are all the members of the school:\n");
        int index = 1;
        foreach (Person person in _persons)
        {
            Console.WriteLine($" {index}. {person.GetPersonDetailsString()}");
            index++;
        }
        Console.WriteLine(" ");
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
        Console.WriteLine("What is the filename of your people file?:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _persons.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] personalRoleInfo = line.Split(":");
                string personFullDetails = personalRoleInfo[0];
             
                string[] personTypeInfo = line.Split("%");

                //Detailed personal info.
                string[] personalFullDetails = personFullDetails.Split(",");
                
                //details of students for subjects.
                string roleInfo = personalRoleInfo[1];
                string[] studentSubjectInfo = roleInfo.Split("-");
                int subjectNumber = studentSubjectInfo.Length;
            

                if (personTypeInfo.Length == 2)
                {
                    string id = personalFullDetails[0]; 
                    string sirName = personalFullDetails[1];
                    string firstName = personalFullDetails[2];
                    string otherNames = personalFullDetails[3];
                    int age = int.Parse(personalFullDetails[4]);
                    string mobileContact = personalFullDetails[5];
                    string motherName = personalFullDetails[6];
                    string fatherName = personalFullDetails[7];
                    string houseLine = personalFullDetails[8];
                    string houseAddress = personalFullDetails[9];
                    bool married = bool.Parse(personalFullDetails[10]);

                    Student student = new Student(id,sirName,firstName,otherNames,age,mobileContact,motherName,fatherName, houseLine, houseAddress,married);
                    _persons.Add(student);
                    _students.Add(student);
                     
                    // this section is to add the subject information to each student.
                    int index = 1;
                    int shift = 1; 
                    for (int i = 0; i < subjectNumber - 1;)
                    {
                        string subjectInfo = studentSubjectInfo[0 + shift];
                        string[] subjectParts = subjectInfo.Split(",");
                        string subjectName = subjectParts[0];
                        string subjectTeacher = subjectParts[1];
                        int totalClassTestScore = int.Parse(subjectParts[2]);
                        int totalExamsScore = int.Parse(subjectParts[3]);
                        int expectedNumberOfClassTests = int.Parse(subjectParts[4]);                            int marksForEachTest = int.Parse(subjectParts[5]);
                        int numberOfCompletedClassTests = int.Parse(subjectParts[6]);
                        string finalGrade = subjectParts[7];
                                
                        //checking the type of subject.
                        string[] determineSubjectType = subjectInfo.Split("|");
                        if (determineSubjectType.Length == 2)
                            {
                                MathsSubject mathsSubject = new MathsSubject(totalClassTestScore, totalExamsScore,expectedNumberOfClassTests, marksForEachTest,numberOfCompletedClassTests, finalGrade);
                                student.GetSubjects().Add(mathsSubject);
                            }

                        else if (determineSubjectType.Length == 3)
                            {
                                EnglishSubject englishSubject = new EnglishSubject(totalClassTestScore, totalExamsScore,expectedNumberOfClassTests, marksForEachTest,numberOfCompletedClassTests, finalGrade);
                                student.GetSubjects().Add(englishSubject);
                            }

                        i += index;    
                        shift++;
                    }                   
            }

                else if (personTypeInfo.Length == 3 || personTypeInfo.Length == 4)
                {
                    string id = personalFullDetails[0]; 
                    string sirName = personalFullDetails[1];
                    string firstName = personalFullDetails[2];
                    string otherNames = personalFullDetails[3];
                    int age = int.Parse(personalFullDetails[4]);
                    string workType = personalFullDetails[5];
                    string mobileContact = personalFullDetails[6];
                    string motherName = personalFullDetails[7];
                    string fatherName = personalFullDetails[8];
                    string houseLine = personalFullDetails[9];
                    string houseAddress = personalFullDetails[10];
                    bool married = bool.Parse(personalFullDetails[11]);


                    if (personTypeInfo.Length == 3)
                    {
                        Teacher teacher = new Teacher(id,sirName,firstName,otherNames,age, workType,mobileContact,motherName,fatherName, houseLine, houseAddress,married);
                        _persons.Add(teacher);
                        _teachers.Add(teacher);
                    }

                    else if (personTypeInfo.Length == 4)
                    {
                        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff(id,sirName,firstName,otherNames,age, workType,mobileContact,motherName,fatherName, houseLine, houseAddress,married);
                        _persons.Add(nonTeachingStaff);
                        _nonTeachingStaff.Add(nonTeachingStaff);
                    }
                }
            }
            Console.WriteLine("Everyone is in!\n");          
        }
    }
}
