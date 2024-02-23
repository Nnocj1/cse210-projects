using System;

public class Person
{
    private string _sirName;
    private string _firstName;
    private string _otherNames;
    private int _age;  
    private string _mobileContact;
    private string _motherName;
    private string _fatherName;
    private string _houseLine;
    private string _houseAddress;
    private bool _married;


    public Person(string sirName, string firstName, string otherNames, int age, string mobileContact, string motherName, string fatherName, string houseLine, string houseAddress, bool married)
    {
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
}