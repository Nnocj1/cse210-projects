using System;

public  class Person
{
    protected string _sirName;
    protected string _firstName;
    protected string _otherNames;
    protected int _age;  
    protected string _mobileContact;
    protected string _motherName;
    protected string _fatherName;
    protected string _houseLine;
    protected string _houseAddress;
    protected bool _married;
    protected string _id;


    public Person(string id, string sirName, string firstName, string otherNames, int age, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married)
    {
        _id = id;
        _sirName = sirName;
        _firstName = firstName;
        _otherNames = otherNames;
        _age = age;
        _mobileContact = mobileContact;
        _motherName = motherName;
        _fatherName = fatherName;
        _houseLine = houseLine;
        _houseAddress = houseAddress;
        _married = married;

    }
    
    public string GetOfficialName()
    {
       return $"NAME: {_sirName}, {_firstName} {_otherNames}.";
    }

    public string GetContactDetails()
    {
        return  $"{_houseAddress}, {_mobileContact} / {_houseLine}." ;
    }
    
    public string GetId()
    {
        return $"{_id}";
    }

    public string GetLiveStatus()
    {   
        string marriageStatus;

        if (_married == true)
        {
            marriageStatus = "Married";
        }

        else
        {
            marriageStatus = "Single";
        }

        return $"Age: {_age}, {marriageStatus}";
    }
    
    public string GetParentsInfo()
    {
        return $"Mother: {_motherName}. Father: {_fatherName}. Home contact: {_houseLine}";
    }
   
    public void SetFirstName()
    {   
        Console.WriteLine("What is your first name?:");
        string myFirstName = Console.ReadLine();
        _firstName = myFirstName;
    }

    public void SetLastName()
    {   
        Console.WriteLine("What is your first name?:");
        string myFirstName = Console.ReadLine();
        _firstName = myFirstName;
    }

    public void setOtherNames()
    {   
        Console.WriteLine("What is your first name?:");
        string myOtherNames = Console.ReadLine();
        _otherNames = myOtherNames;
    }

    public virtual string GetPersonDetailsString()
    {
        return "";
    }

    public virtual string GetPersonStringRepresentation()
    {
        return "";
    }
    
    public string GetPersonFullDetails()
    {
        return $"{_id},{_sirName},{_firstName},{_otherNames},{_age},{_mobileContact}, {_motherName},{_fatherName},{_houseLine},{_houseAddress},{_married}";
    }

}