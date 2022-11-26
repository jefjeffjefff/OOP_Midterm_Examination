using OOP_Midterm_Examination.Database;
using OOP_Midterm_Examination.Students;

namespace OOP_Midterm_Examination.Services
{
    public class EnrollStudentService
    {
        public void Enroll(Student student)
        {
            decimal totalFee = 0;


            if (student.Grade == 1)
            {
                if (student.Age < 8)
                {
                    Console.WriteLine("This student is not allowed to enroll.");
                }

                // Tuition + books + miscellaneous.
                totalFee = 13000 + 2500 + 1300;
            }
            else if (student.Grade == 2)
            {
                Console.WriteLine("Get the student's Grade 1 report card.");

                // Tuition + books + miscellaneous + Deped's approved increase on tuition fee.
                totalFee = 15000 + 3000 + 1200;
            }
            else if (student.Grade == 3)
            {
                Console.WriteLine("Get the student's Grade 2 report card.");

                // Tuition + books + miscellaneous
                totalFee = 15000 + 3000 + 1200;

                // For Grade 3 lipa students, deduct totalFee from lipa scholarship program.
                if (student.Address.Contains("Lipa"))
                {
                    totalFee -= 1000;
                }
            }
            else if (student.Grade == 4)
            {
                Console.WriteLine("Get the student's Grade 3 report card. Make sure he/she passed " +
                    "the National Achievement Test first.");

                // Tuition + books + miscellaneous
                totalFee = 15000 + 3000 + 1200;
            }
            else if (student.Grade == 5)
            {
                Console.WriteLine("Get the student's Grade 4 report card.");

                // Tuition + books + miscellaneous
                totalFee = 15000 + 3000 + 1200;
            }
            else if (student.Grade == 6)
            {
                Console.WriteLine("Get the student's Grade 5 report card.");

                // Tuition + books + miscellaneous
                totalFee = 15000 + 3000 + 1200;
            }
            else if (student.Grade == 7 && student.Curriculum == "SCI-MATH")
            {
                Console.WriteLine("Get the student's elementary diploma. Make sure his/her GWA is equal or greater than 90.");

                // Tuition + books + miscellaneous
                totalFee = 15000 + 3000 + 1200;
            }

            // TO DO: Continue Grade 8-10 enrollment processes. 
            MicrosoftSqlDatabase microsoftSqlDatabase = new MicrosoftSqlDatabase();

            var query = $@"INSERT INTO EnrolledStudents(firstName, lastName, grade, totalFee) 
                            VALUES({student.FirstName},{student.LastName},{student.Grade},{totalFee})";

            microsoftSqlDatabase.Query(query);
        }
    }
}
