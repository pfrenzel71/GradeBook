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
            tbook.AddGrade(89.1);
            tbook.AddGrade(90.5);
            tbook.AddGrade(77.3);

            //act
            var results = tbook.GetStatistics();

            //assert
            Assert.Equal(85.6, results.Average, 1);
            Assert.Equal(90.5, results.High, 1);
            Assert.Equal(77.3, results.Low, 1);
        }
    }
}
