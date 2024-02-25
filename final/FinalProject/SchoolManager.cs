using System;
using System.IO;

public class SchoolManager
{
    private List<Person> _persons = new List<Person>();

    public SchoolManager(List<Person> persons)
    {
        _persons = persons;

    }

    public void Start()
    {
        while (true)
        {             
            //Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Person\n 2. View All School Members. \n 3. View all Students. \n 4. View all Teachers. \n 5. View All Non-Teaching Staff.\n 6. Save People.\n 7. Load People.\n 8. Manage Student Record \n 9. Quit.");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            

            if (choice == 1)
            {
                CreatePerson(); //Add student with  subject info, teacher, or non-teaching staff.
            }

            else if (choice == 2)
            {
                ListPersonDetails();/// just to let's say view all information about all school members
            }

            else if (choice == 3)
            {
                ListStudentNames();
            }

            else if (choice == 4)
            {
                ListTeacherNames();
            }

            else if (choice == 5)
            {
                ListNonTeachingStaffNames();
            }
            else if (choice == 6)
            {
                SavePeople();
            }

            else if (choice == 7)
            {
                LoadPeople();
            }

            else if (choice == 8)
            {
                ManageStudentRecords();
            }

            else if (choice == 9)
            {
                break;
            }
        }
    }
    
    public void ManageStudentRecords()
    {   
        Console.WriteLine("Which action do you want to take?: ");
        Console.WriteLine("1. Update Student Info\n2. Enter Student Scores\n3. Display Student ReportCard");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter the Student's ID: ");
        string studentId = Console.ReadLine();

        foreach (Student student in _persons.OfType<Student>())
        {
            if (student.GetId() == studentId)
            {       
                if (choice == 1)
                {
                    UpdateStudentInfo(student);
                }
                else if (choice == 2)
                {
                    EnterStudentScores(student);
                }
                else if (choice == 3)
                {
                    student.DisplayStudentReportCard();
                }
                return; // After finding the student, return. Don't search further.
            }
        }
        Console.WriteLine("Student not found!");
    }

    public void UpdateStudentInfo(Student student)
    {
        Console.WriteLine("Select the type of information to Update: ");
        Console.WriteLine("1. First name\n2. Sir name\n3. OtherNames\n4. Mobile contact\n5. Mother name\n6. Father name\n7. House Line\n8. House address.\n Marriage.");
        int updateChoice = int.Parse(Console.ReadLine());

        
        if (updateChoice == 1)
            {    
            student.SetFirstName();
            }

        else if (updateChoice == 2)
        {   
            student.SetLastName();
        }      
        
        else if (updateChoice ==  3)
        {   
            student.SetOtherNames();
        }

        else if (updateChoice == 4)
        {
            student.SetMobileContact(); 
        }
        
        else if (updateChoice == 5)
        {
            student.SetMotherName(); 
        }

        else if (updateChoice == 6)
        {
            student.SetFatherName(); 
        }

        else if (updateChoice == 7)
        {
            student.SetHouseLine(); 
        }

        else if (updateChoice == 8)
        {
            student.SetHouseAddress();
        }
        
        else if (updateChoice == 9)
        {
            student.SetMarriage(); 
        }

        else
        {
            Console.Write("Invalid Input");
        }
    }

    public void EnterStudentScores(Student student)
    {
        Console.WriteLine("1. Record student class Test\n2. Record Student Final Exams");
        int testExams = int.Parse(Console.ReadLine());

        if (testExams == 1)
        {
            Console.WriteLine("1. Maths \n2.English: ");
            int  subjectChoice = int.Parse(Console.ReadLine());
            if (subjectChoice == 1)
            {  
                foreach (MathsSubject subject in student.GetSubjects())
                {
                    if (subject is MathsSubject)
                    {
                        subject.RecordClassTest();
                    }
                }                
            }
            if (subjectChoice == 3)
            {  
                foreach (EnglishSubject subject in student.GetSubjects())
                {
                    if (subject is EnglishSubject)
                    {
                        subject.RecordClassTest();
                    }
                }
                
            }

            else if (subjectChoice ==2)
            {
                foreach (EnglishSubject subject in student.GetSubjects())
                {
                    {
                        subject.RecordClassTest();   
                    }
                }
            }

            else
            {
                Console.WriteLine($"Subject not found!");
            }
        }
        else if (testExams == 2)
        {
            Console.WriteLine("1. Maths \n2.English: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {  
                foreach (MathsSubject subject in student.GetSubjects())
                {   if (subject is MathsSubject)
                    {
                        subject.RecordExamScore();   
                    }
                }
                
            }

            else if (choice == 2)
            {
                foreach (EnglishSubject subject in student.GetSubjects())
                {   
                    if (subject is EnglishSubject)
                    {
                        subject.RecordExamScore();   
                    }
                }
            }
        }    
    }


    public void ListPersonNames()
    {   
        int index = 1;
        foreach (Person person in _persons.OfType<Person>())
        {
            Console.WriteLine($"{index}. {person.GetOfficialName()}");
        }
        Console.WriteLine(" ");
    }
    public void ListStudentNames()
    {   
        int index = 1;
        foreach(Student student in _persons.OfType<Student>())
        {
            Console.WriteLine($"{index}. {student.GetOfficialName()}");
            index++;
        }
        Console.WriteLine(" ");
    }

    public void ListTeacherNames()
    {   int index = 1;
        foreach(Teacher teacher in _persons.OfType<Teacher>())
        {   
            
            Console.WriteLine($"{index}. {teacher.GetOfficialName()}");
            index++;
        }
        Console.WriteLine(" ");
    }

    
    public void ListNonTeachingStaffNames()
    {   
        int index = 1;
        foreach (NonTeachingStaff person in _persons.OfType<NonTeachingStaff>())
        {
            Console.WriteLine($"{index}. {person.GetOfficialName()}");
            index++;
        }
        Console.WriteLine(" ");
    }

    public void ListPersonDetails()
    {
        Console.WriteLine("These are all the members of the school:\n");
        int index = 1;
        foreach (Person person in _persons.OfType<Person>())
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
                       
                    }

                    else if (personTypeInfo.Length == 4)
                    {
                        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff(id,sirName,firstName,otherNames,age, workType,mobileContact,motherName,fatherName, houseLine, houseAddress,married);
                        _persons.Add(nonTeachingStaff);
                       
                    }
                }
            }
            Console.WriteLine("Everyone is in!\n");          
        }
    }
}
