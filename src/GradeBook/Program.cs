using System;
using GradeBook.BusinessLogic;

namespace GradeBook
{
    
    class Program
    {
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A Grade was added");
        }

        static void Main(string[] args)
        {
            //arrange
            IBook book = new DiskBook("Paul's GradeBook");
            book.GradeAdded += OnGradeAdded;

            Grades.EnterGrades(book);

            //act
            var stats = book.GetStatistics();
            
            Console.WriteLine($"For the Book Named :{book.Name}");
            Console.WriteLine($"Lowest Grade is : {stats.Low}");
            Console.WriteLine($"Highest Grade is : {stats.High}");
            Console.WriteLine($"Avg Grade is : {stats.Average:N0}");
            Console.WriteLine($"Letter Grade is : {stats.Letter}");
        }

        
    }
}
