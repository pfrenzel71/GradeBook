using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {      
            var book = new Book("Paul's GradeBook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"Lowest Grade is : {stats.Low}");
            Console.WriteLine($"Highest Grade is : {stats.High}");
            Console.WriteLine($"Avg Grade is : {stats.Average:N1}");
        }
    }
}
