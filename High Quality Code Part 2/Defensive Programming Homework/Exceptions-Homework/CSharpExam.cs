using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < MinGrade || value > MaxGrade)
            {
                throw new ArgumentOutOfRangeException("score", "Score must be in the range of 0 to 100 inclusive.");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, MinGrade, MaxGrade, "Exam results calculated by score.");
    }
}
