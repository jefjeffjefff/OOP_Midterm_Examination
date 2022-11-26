namespace OOP_Midterm_Examination.Services
{
    public class CollegeStudentReportCardService : IReportCardService
    {
        public void PrintAverage()
        {
            Console.WriteLine("I'm printing average in college format.");
        }

        public void PrintSubjectsWithGrades()
        {
            Console.WriteLine("I'm printing subjects with grades in college format.");
        }

        public void PrintTotalUnits()
        {
            Console.WriteLine("I'm printing total units.");
        }
    }
}
