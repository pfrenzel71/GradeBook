using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAvgGrade()
        {
            //arrange
            var tbook = new Book("Paul's GradeBook");
           
            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to quit");
                var input = Console.ReadLine();
                if (!input.Equals("q"))
                {
                    break;
                }
                var grade = double.Parse(input);
                tbook.AddGrade(grade);
            }

            //act
            var results = tbook.GetStatistics();

            //assert
            Assert.Equal(85.6, results.Average, 1);
            Assert.Equal(90.5, results.High, 1);
            Assert.Equal(77.3, results.Low, 1);
            Assert.Equal('B', results.Letter);
        }
    }
}
