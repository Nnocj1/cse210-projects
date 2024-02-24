using System;

public class EnglishSubject: Subject
{
    private string _subjectTeacher = "Sarah Owen";

    private string _subjectName = "English";
  
    public EnglishSubject(int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade): base(totalClassTestScore, totalExamsScore, expectedNumberOfClassTests, marksForEachTest, numberOfCompletedClassTests, finalGrade)
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

        return $"-{_subjectName},{_subjectTeacher},{_totalClassTestScore},{_totalExamsScore},{_expectedNumberOfClassTests},{_marksForEachTest},{_numberOfCompletedClassTests},{_finalGrade} | 1 | 2";
    }
}  