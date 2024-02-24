using System;

public class Teacher : Person
{
    private string _teachingSubject;   

    public Teacher(string id, string sirName, string firstName, string otherNames, int age, string teachingSubject, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married) : base(id,sirName, firstName, otherNames, age, mobileContact, motherName, fatherName,  houseLine, houseAddress,  married)
    {
       _teachingSubject = teachingSubject;
    }
    
    public override string GetPersonDetailsString()
    {
        return $"{GetOfficialName()} : ID - {GetId()} : Teaching Subject - {_teachingSubject}";
    }
    
    public override string GetPersonFullDetails()
    {
        return $"{_id},{_sirName},{_firstName},{_otherNames},{_age},{_teachingSubject},{_mobileContact}, {_motherName},{_fatherName},{_houseLine},{_houseAddress},{_married}";
    }
    public override string GetPersonStringRepresentation() 
    {    
        return $"{GetPersonFullDetails()} : {_teachingSubject}  % 1 % 2";
    }

}