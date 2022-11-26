using OOP_Midterm_Examination.Services;

public class ElementaryStudentReportCardService : IReportCardService
{
    public void PrintAverage()
    {
        Console.WriteLine("I'm printing average in elementary format.");
    }

    public void PrintSubjectsWithGrades()
    {
        Console.WriteLine("I'm printing subjects with grades in elementary format.");
    }

    public void PrintTotalUnits()
    {
        throw new NotImplementedException();
    }
}
