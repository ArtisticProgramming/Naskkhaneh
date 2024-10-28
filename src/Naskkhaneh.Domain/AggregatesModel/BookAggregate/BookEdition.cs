using LibraryCatalog.Domain.Exceptions;

namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public class BookEdition : ValueObject
    {
        public BookEdition(int pageNumber, BookSize bookSize, BookFormat bookFormat, string editionNumber, DateTime publishedDate, string publisher)
        {
            if (pageNumber <= 0)
            {
                throw new LibraryCatalogDomainException($"Page number '{pageNumber}' is invalid");
            }

            PageNumber=pageNumber;
            BookSize=bookSize;
            BookFormat=bookFormat;
            EditionNumber=editionNumber;
            PublishedDate=publishedDate;
            Publisher=publisher;
        }

        public int PageNumber { get; set; }
        public BookSize BookSize { get; set; }
        public BookFormat BookFormat { get; set; }
        public required string EditionNumber { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string Publisher { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
