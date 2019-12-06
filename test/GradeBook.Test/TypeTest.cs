using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTests
    {
        [Fact]
        public void CSharpCanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetNameByRef(ref book1, "New Name");
            //act


            //assert
            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetNameByRef(ref Book book, string name)
        {
            // ref.. denotes its not a copy of the varible, 
            // out keyword is also used, but the object is not assigned or intialized
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CSharpPassByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            //act


            //assert
            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            // Create a new reference value
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            //act


            //assert
            Assert.Equal("New Name", book1.Name);
           
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");


            //act
            

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;


            //act


            //assert            
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
