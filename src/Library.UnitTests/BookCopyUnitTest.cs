using LibraryCatalog.Domain.AggregatesModel.BookAggregate;
using LibraryCatalog.Domain.Exceptions;

namespace Library.UnitTests
{
    public class BookCopyUnitTest
    {
        [Fact]
        public void PerformCheckout_Should_Set_CheckedOut_And_IsAvailable()
        {
            BookCopy bookCopy = new BookCopy("ABC12345678", true);

            bookCopy.PerformCheckout();

            Assert.False(bookCopy.IsAvailable);
            Assert.True(bookCopy.CheckedOut);
        }

        [Fact]
        public void PerformCheckout_When_BookCopy_Not_Avilable_Should_Throw_LibraryCatalogDomainException()
        {
            BookCopy bookCopy = new BookCopy("ABC12345678", false);

            LibraryCatalogDomainException exception = Assert.Throws<LibraryCatalogDomainException>(
                () => bookCopy.PerformCheckout());

            Assert.Equal(typeof(LibraryCatalogDomainException), exception.GetType());
        }

        [Fact]
        public void ReturnBookCopy_Should_Set_CheckedOut_And_IsAvailable()
        {
            BookCopy bookCopy = new BookCopy("ABC12345678", false);

            bookCopy.ReturnBookCopy();

            Assert.True(bookCopy.IsAvailable);
            Assert.False(bookCopy.CheckedOut);
        }

        [Fact]
        public void ReturnBookCopy_When_BookCopy_Avilable_Should_Throw_LibraryCatalogDomainException()
        {
            BookCopy bookCopy = new BookCopy("ABC12345678", true);

            LibraryCatalogDomainException exception = Assert.Throws<LibraryCatalogDomainException>(
                () => bookCopy.ReturnBookCopy());

            Assert.Equal(typeof(LibraryCatalogDomainException), exception.GetType());
        }

    }
}
