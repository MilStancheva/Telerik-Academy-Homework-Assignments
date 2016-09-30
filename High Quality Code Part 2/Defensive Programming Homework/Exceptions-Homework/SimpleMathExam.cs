using System;

public class SimpleMathExam : Exam
{
    private const int MinProblemSolved = 0;
    private const int MaxProblemSolved = 10;
    private const int BadGradeMaxProblems = 2;
    private const int AverageGradeMaxProblems = 5;
    private const int GoodGradeMaxProblems = 8;

    private const string BadResultComment = "Bad result: nothing done.";
    private const string AverageResultComment = "Average result: needs to improve their performance to achieve good results.";
    private const string GoodResultComment = "Good result: almost everything is done correctly.";
    private const string ExcellentResultComment = "Excellent result: everything is done correctly.";

    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemSolved;
        }

        private set
        {
            if (value < MinProblemSolved)
            {
                value = MinProblemSolved;
            }
            else if (value > MaxProblemSolved)
            {
                value = MaxProblemSolved;
            }
            else
            {
                this.problemSolved = value;
            }
        }
    }

    public override ExamResult Check()
    {
        string comment = string.Empty;

        if (this.ProblemsSolved <= BadGradeMaxProblems)
        {
            comment = BadResultComment;
        }
        else if (this.ProblemsSolved <= AverageGradeMaxProblems)
        {
            comment = AverageResultComment;
        }
        else if (this.ProblemsSolved <= GoodGradeMaxProblems)
        {
            comment = GoodResultComment;
        }
        else
        {
            comment = ExcellentResultComment;
        }

        return new ExamResult(this.ProblemsSolved, MinProblemSolved, MaxProblemSolved, comment);
    }
}
