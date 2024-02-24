using System;

public class MathsSubject: Subject
{
    private string _subjectTeacher = "John Mills";

    private string _subjectName = "Maths10";
  
    public MathsSubject(int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade): base( totalClassTestScore, totalExamsScore, expectedNumberOfClassTests, marksForEachTest, numberOfCompletedClassTests, finalGrade)
    {
    
    }
    
    public override string GetSubjectName()
    {
       return $"{_subjectName}.";
    }

    public override string GetSubjectTeacher()
    {
       return $"{_subjectTeacher}.";
    }

    public override string GetSubjectDetailsString()
    {        
        return $"Test Score: {_totalClassTestScore/2} + {_totalExamsScore/2} : {_finalGrade} -- {_subjectTeacher}";
    }

    public  override string GetSubjectStringRepresentation() 
    {    
        return $"-{_subjectName},{_subjectTeacher},{_totalClassTestScore},{_totalExamsScore},{_expectedNumberOfClassTests},{_marksForEachTest},{_numberOfCompletedClassTests},{_finalGrade}, | 1";
    }   
}    