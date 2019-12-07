using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //arrange
            var tbook = new Book("Paul's GradeBook");

            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to quit");
                var input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    break;
                }
                
                try
                {
                    var grade = double.Parse(input);
                    tbook.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //act
            var results = tbook.GetStatistics();

            var stats = tbook.GetStatistics();

            Console.WriteLine($"The Category is : {Book.CATEGORY}");
            Console.WriteLine($"For the Book Named :{tbook.Name}");
            Console.WriteLine($"Lowest Grade is : {stats.Low}");
            Console.WriteLine($"Highest Grade is : {stats.High}");
            Console.WriteLine($"Avg Grade is : {stats.Average:N1}");
            Console.WriteLine($"Letter Grade is : {stats.Letter}");
        }
    }
}
