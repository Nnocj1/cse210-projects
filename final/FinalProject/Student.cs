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
    
    public void DisplayStudentReportCard()
    {
        Console.WriteLine("                         LDS COMMUNITY SCHOOL ACADEMY                 \n");
        Console.WriteLine("                               Terminal Report                   ");
        Console.WriteLine($"{GetOfficialName()}............................................Term 1");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("    Subject    |     Class Test     |      Exams Score     |      Grade     |");

        int index = 1;
        foreach (Subject subject in _subjects)
        {
            Console.WriteLine($"    {subject.GetSubjectName()}    |     {subject.GetTotalTestScoreForRecording()}             |      {subject.GetTotalExamsScoreForRecording()}               |   {subject.GetFinalGrade()}     |");
            index++;
        } 

        Console.WriteLine("---------------------------------------------------------------------------");

    }

    public override string GetPersonDetailsString()
    {
        return $"{GetOfficialName()} : ID - {GetId()}";
    }
    
    public override string GetPersonFullDetails()
    {
        return $"{_id},{_sirName},{_firstName},{_otherNames},{_age},{_mobileContact}, {_motherName},{_fatherName},{_houseLine},{_houseAddress},{_married}";
    }
    public override string GetPersonStringRepresentation() 
    {    
        string allSubjects ="";
        foreach (Subject subject in _subjects)
        {
            allSubjects = allSubjects + subject.GetSubjectStringRepresentation();
        }
        return $"{GetPersonFullDetails()} : {allSubjects} % 1";
    }

}    