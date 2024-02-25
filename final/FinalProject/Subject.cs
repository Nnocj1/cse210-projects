using System;

public abstract class Subject
{
    protected int _totalClassTestScore;
    protected int _totalExamsScore;  
    protected int _expectedNumberOfClassTests;
    protected int _marksForEachTest;
    protected int _numberOfCompletedClassTests;
    protected string _finalGrade;
  
    public Subject(int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade)
    {
        _totalClassTestScore = totalClassTestScore;
        _totalExamsScore = totalExamsScore;
        _expectedNumberOfClassTests = expectedNumberOfClassTests;
        _marksForEachTest = marksForEachTest;
        _numberOfCompletedClassTests = numberOfCompletedClassTests;
        _finalGrade = finalGrade;
    
    }
    
    public abstract string GetSubjectName();

    public abstract string GetSubjectTeacher();

    public void RecordClassTest()
    {
        Console.Write("\nEnter the score (out of 25): ");
        int score = int.Parse(Console.ReadLine());
        _totalClassTestScore += score;
        _numberOfCompletedClassTests++;
    }
    
    public  int GetTotalTestScoreForRecording()
    {
        return _totalClassTestScore/2;
    }
    
    public int GetTotalExamsScoreForRecording()
    {
        return _totalExamsScore/2;
    }

    public void RecordExamScore()
    {
        Console.Write("\nNew Exams score?: ");
        string responds = Console.ReadLine();
        int examsScore = int.Parse(responds);

        _totalExamsScore += examsScore;
    }
    public void UpdateFinalGrade()
    {
        int totalPercent = _totalClassTestScore/2 + _totalExamsScore/2;

        if ( totalPercent>= 93)
        {
            _finalGrade = "A";
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

    public abstract string GetSubjectDetailsString();
   
    public  abstract string GetSubjectStringRepresentation();    
   
}    