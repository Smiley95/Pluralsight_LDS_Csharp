using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void ChangeBookNameValueTest()
        {
        //Given
            var book1 = GetBook("book1");
        //When
            setBookName(book1, "new book");
        //Then
            Assert.Equal(book1.Name,"new book");
        }
        void setBookName(Book book,string name)
        {
            book.Name= name;
        }
        [Fact]
        public void BookType()
        {
        //Arrange
            var book1=GetBook("b1");
            var book2=GetBook("b2");
        //When
            Assert.Equal(book1.Name,"b1");
            Assert.Equal(book2.Name,"b2");
        //Then
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}