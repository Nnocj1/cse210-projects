using System;

public class Student : Person
{
    private List<Subject> _subjects;

    
    public Student(string id,string sirName, string firstName, string otherNames, int age, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married) : base(id,sirName, firstName, otherNames, age, mobileContact, motherName, fatherName,  houseLine, houseAddress,  married)
    {
        _subjects = new List<Subject>();
    
    }

    public List<Subject> GetSubjects()
    {
        return _subjects;
    }

    public void SetSubjects(List<Subject> newSubjects)
    {
        _subjects = newSubjects;
    }
    
    public void AddASubjectToStudy()
    {
       Console.WriteLine("Note that we offer only the following Subjects:");
       Console.WriteLine(" 1. Maths10.\n 2. English.\n 3. Science.\nPreferable, enter the name of only of the above: ");
       string subjectName = Console.ReadLine();
       Subject newSubject = new Subject(subjectName, "UnKnown", 0, 0, 4, 25, 0, "unknown");// I'm setting this as default. Later that can be updated.

       _subjects.Add(newSubject);

    }

    public void DisplayStudentReportCard()
    {
        Console.WriteLine("                         LDS COMMUNITY SCHOOL ACADEMY                 \n");
        Console.WriteLine("                               Terminal Report                   ");
        Console.WriteLine($"{GetOfficialName()}............................................Term 1");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("    Subject    |     Class Test     |      Total Score     |      Grade     |");

        int index = 1;
        foreach (Subject subject in _subjects)
        {
            Console.WriteLine($"    {subject.GetSubjectName()}    |     {subject.GetTotalTestScoreForRecording()}             |      {subject.GetTotalExamsScoreForRecording()}               |   {subject.GetFinalGrade()}     |");
            index++;
        } 

        Console.WriteLine("----------------------------------------------------------------------");

    }


    public override string GetPersonDetailsString()
    {
        
        return "df";
    }

    public override string GetPersonStringRepresentation() 
    {    
        
        return "fg";
    }

}    