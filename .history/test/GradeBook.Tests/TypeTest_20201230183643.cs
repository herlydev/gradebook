using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
