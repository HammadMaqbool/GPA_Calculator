using System;

class GPA
{
    public GPA()
    {
    }

    public double PercentageCalculator150(double subjectMarks, int totalMarks)
    {
        return (subjectMarks / totalMarks) * 100;
    }

    public double GetGPA(double obtainedMarks, int totalMarks)
    {
        return GPACalculator(GradeDecider(PercentageCalculator150(obtainedMarks, totalMarks)));
    }

    public string GradeDecider(double subjectPercentage)
    {
        string grade = "";
        if (subjectPercentage < 50)
        {
            grade = "F";
        }
        else if (subjectPercentage >= 50 && subjectPercentage <= 64.9)
        {
            grade = "C";
        }
        else if (subjectPercentage >= 65 && subjectPercentage <= 71.9)
        {
            grade = "B";
        }
        else if (subjectPercentage >= 72 && subjectPercentage <= 79.9)
        {
            grade = "B+";
        }
        else if (subjectPercentage >= 80 && subjectPercentage <= 89.9)
        {
            grade = "A";
        }
        else if (subjectPercentage >= 90)
        {
            grade = "A+";
        }
        return grade;
    }

    public double GPACalculator(string obtainedGrade)
    {
        double GPAPoint = 0.00;

        if (obtainedGrade == "F")
        {
            GPAPoint = 0.00;
        }
        else if (obtainedGrade == "C")
        {
            GPAPoint = 2.0;
        }
        else if (obtainedGrade == "B")
        {
            GPAPoint = 3.0;
        }
        else if (obtainedGrade == "B+")
        {
            GPAPoint = 3.5;
        }
        else if (obtainedGrade == "A" || obtainedGrade == "A+")
        {
            GPAPoint = 4.0;
        }
        return GPAPoint;
    }
}
