using System;

public class Teacher : Person
{
    private string _teachingSubject;   

    public Teacher(string id, string sirName, string firstName, string otherNames, int age, string teachingSubject, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married) : base(id,sirName, firstName, otherNames, age, mobileContact, motherName, fatherName,  houseLine, houseAddress,  married)
    {
       _teachingSubject = teachingSubject;
    }
    

    public override string GetPersonStringRepresentation() 
    {    
        
        return "fg";
    }

}