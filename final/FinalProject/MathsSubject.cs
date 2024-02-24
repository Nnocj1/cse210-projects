using System;

public class MathsSubject: Subject
{
    
  
    public MathsSubject(string subjectName, string subjectTeacher, int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade): base(subjectName, subjectTeacher, totalClassTestScore, totalExamsScore, expectedNumberOfClassTests, marksForEachTest, numberOfCompletedClassTests, finalGrade)
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

    public override void RecordClassTest()
    {
      

        _totalClassTestScore += _marksForEachTest;
        _numberOfCompletedClassTests++;
    }
    
    public override int GetTotalTestScoreForRecording()
    {
        return _totalClassTestScore/2;
    }
    
    public override int GetTotalExamsScoreForRecording()
    {
        return _totalExamsScore/2;
    }
    public override void RecordExamScore()
    {
        Console.WriteLine("New Exams score?: ");
        string responds = Console.ReadLine();
        int examsScore = int.Parse(responds);

        _totalExamsScore += examsScore;
    }
    public override void UpdateFinalGrade()
    {
        int totalPercent = _totalClassTestScore/(_expectedNumberOfClassTests * _marksForEachTest) * 100;

        if ( totalPercent>= 93)
        {
            _finalGrade = "A+";
        }

        else if (totalPercent < 93 && totalPercent > 89 )
        {
            _finalGrade = "A-";
        }

        else if (totalPercent < 90 && totalPercent > 79 )
        {
            _finalGrade = "B";
        }

        else if (totalPercent < 80 && totalPercent > 59 )
        {
            _finalGrade = "C";
        }

        else if (totalPercent < 60 && totalPercent > 49 )
        {
            _finalGrade = "D";
        }

        else if (totalPercent < 50)
        {
            _finalGrade = "F";
        }

        else
        {
            _finalGrade = "Invalid";
        }

    }
    public override string GetFinalGrade()
    {
        return $"{_finalGrade}";
    }

    public override string GetSubjectDetailsString()
    {
       

        return $"";
    }

    public override string GetSubjectStringRepresentation() 
    {    
        return $"";
    }
   
}    