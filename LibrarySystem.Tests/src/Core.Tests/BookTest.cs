

using LibrarySystem.Core.src.Entity;

namespace LibrarySystem.Tests.src.Core.Tests
{
    public class BookTest // consider as a test suit
    {
        [Fact] // single test case - cannot pass parameter to the test case
        public void Test1()
        {
            Assert.True(true); //similar to Expect() in Jest
        }
        [Fact]
        public void CompareCalculation()
        {
            var cal1 = 3+4;
            var cal2 = 5 + 6;
            Assert.NotEqual(cal1, cal2);
        }
        [Theory]// follow data-driven testing
        [InlineData(10,5,5)]
        [InlineData(0,10,-10)] 
        public void CompareSubstraction(int a, int b, int c)
        {
            var result = a-b;
            Assert.Equal(result, c);
        }
        [Fact]
        public void CreateBook_ValidData_CreateNewBook()
        {
            var book = new Book("book1", 10);
            Assert.Equal("book1", book.Title);
            Assert.Equal(10, book.Price);
        }
        [Fact]
        public void CreateBook_InvalidData_ThrowError()
        {
            Assert.Throws<InvalidDataException>(()=>new Book("book1",-10));
        }

        [Theory]
        [InlineData("book", 10.0, "book1",5.0,"book1", 5.0)]
        [InlineData("book", 10.0,"book1", null, "book1",10.0)]
        public void UpdateBook_MultipleData_ReturnUpdated(string title, double price, string?updatedTitle, double? updatedPrice, string newTitle, double newPrice)
        {
            var book = new Book(title, price);
            book.UpdateBook(updatedTitle, updatedPrice);
            Assert.Equal(book.Title, newTitle);
            Assert.Equal(book.Price, newPrice);
            
        }
    }
}