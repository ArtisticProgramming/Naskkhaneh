using LibraryCatalog.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public class Book
    {
        public Book(string iSBN, string title, List<Author> authors, DateTime yearPublished, BookEdition edition)
        {
            ISBN=iSBN;
            Title=title;
            Authors=authors;
            YearPublished=yearPublished;
            Copies= new List<BookCopy>();
            Edition=edition;
        }

        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public BookEdition Edition { get; private set; }

        public bool IsThereAnyCopyAvailableInLibrary
        {
            get { return Copies.Any(x => x.IsAvailable); }
        }

        public int NumberOfCopies
        {
            get { return Copies.Count(); }
        }

        public List<Author> Authors { get; private set; }
        public DateTime YearPublished { get; private set; }
        public List<BookCopy> Copies { get; private set; }

        public void AddBookCopy(BookCopy bookCopy)
        {
            var isThisBookCopyExist = Copies.Exists(x => x.CopyId == bookCopy.CopyId);

            if (isThisBookCopyExist)
                throw new LibraryCatalogDomainException($"The book status with copy id {bookCopy.CopyId} already added.");

            if (bookCopy.CheckedOut)
                throw new LibraryCatalogDomainException($"The book with copy id {bookCopy.CopyId} could not be add when is in the state of checkedout.");

            Copies.Add(bookCopy);
        }

    }
}
