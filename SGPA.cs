class SGPA
{
    private int totalCreditHours;
    private GPA mygpa = new GPA();

    public SGPA(int _TotalCreditHours)
    {
        totalCreditHours = _TotalCreditHours;
    }

    //Per subject product
    private double Product_of_gpa_and_credithours(double subjectCreditHours, double subjectGpa)
    {
        return subjectCreditHours * subjectGpa;
    }

    //Give total sum of product
    private double sgpa_processor(double sum_of_products)
    {
        return sum_of_products / totalCreditHours;
    }

    public void sgpa_calculator()
    {
        double obtainMarks;
        int totalMarks;
        int numberOfSubjects;
        int creditHours;
        int sumOfProducts = 0;
        double finalSgpa;
        Console.Write("How much Subjects you are studing in this semester? ");
        numberOfSubjects = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSubjects; i++)
        {
            Console.Write("Please enter your obtain marks of subject " + (i + 1) + " ");
            obtainMarks = double.Parse(Console.ReadLine());

            Console.Write("Please enter total marks of the subject " + (i + 1) + " ");
            totalMarks = int.Parse(Console.ReadLine());

            Console.Write("Please enter the credit hours of subject " + (i + 1));
            creditHours = int.Parse(Console.ReadLine());

            sumOfProducts = sumOfProducts + (int)Product_of_gpa_and_credithours(creditHours, mygpa.GetGPA(obtainMarks, totalMarks));
            Console.WriteLine();
        }
        finalSgpa = sgpa_processor(sumOfProducts);
        if (finalSgpa > 4)
        {
            Console.WriteLine("Your CGPA is " + Math.Round(finalSgpa));
        }
        else
        {
            Console.WriteLine("Your CGPA is " + finalSgpa);
        }

    }

}
