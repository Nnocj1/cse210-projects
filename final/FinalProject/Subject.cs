using System;

public class Subject
{
    private string _subjectName;
    private string _subjectTeacher;
    private int _totalClassTestScore;
    private int _totalExamsScore;  
    private int _expectedNumberOfClassTests;
    private int _marksForEachTest;
    private int _numberOfCompletedClassTests;
    private string _finalGrade;
  
    public Subject(string subjectName, string subjectTeacher, int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade)
    {
        _subjectName = subjectName;
        _subjectTeacher = subjectTeacher;
        _totalClassTestScore = totalClassTestScore;
        _totalExamsScore = totalExamsScore;
        _expectedNumberOfClassTests = expectedNumberOfClassTests;
        _marksForEachTest = marksForEachTest;
        _numberOfCompletedClassTests = numberOfCompletedClassTests;
        _finalGrade = finalGrade;
    
    }
    
    public string GetSubjectName()
    {
       return $"{_subjectName}.";
    }

    public string GetSubjectTeacher()
    {
       return $"{_subjectTeacher}.";
    }

    public void RecordClassTest()
    {
      

        _totalClassTestScore += _marksForEachTest;
        _numberOfCompletedClassTests++;
    }
    
    public int GetTotalTestScoreForRecording()
    {
        return _totalClassTestScore/2;
    }
    
    public int GetTotalExamsScoreForRecording()
    {
        return _totalExamsScore/2;
    }
    public void RecordExamScore()
    {
        Console.WriteLine("New Exams score?: ");
        string responds = Console.ReadLine();
        int examsScore = int.Parse(responds);

        _totalExamsScore += examsScore;
    }
    public void UpdateFinalGrade()
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
    public string GetFinalGrade()
    {
        return $"{_finalGrade}";
    }
   
}    