using System;

public class NonTeachingStaff : Person
{
    private string _role;
    
    public NonTeachingStaff(string id, string sirName, string firstName, string otherNames, int age, string role, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married) : base(id,sirName, firstName, otherNames, age, mobileContact, motherName, fatherName,  houseLine, houseAddress,  married)
    {
          _role =role;  
    }
    

    public override string GetPersonDetailsString()
        {

            return $"";
        }

    public override string GetPersonStringRepresentation() 
    {    
       
        return $"";
    }
}