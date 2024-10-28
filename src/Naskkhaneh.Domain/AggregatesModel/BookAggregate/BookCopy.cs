using LibraryCatalog.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public class BookCopy : Entity
    {
        public string CopyId { get; private set; }
        public bool CheckedOut { get; private set; }
        public bool IsAvailable { get; private set; }

        public BookCopy(string copyId,bool isAvailable)
        {
            CopyId=copyId;
            IsAvailable = isAvailable;
            CheckedOut=false;
        }

        public void PerformCheckout()
        {
            if (this.IsAvailable==false)
            {
                throw new LibraryCatalogDomainException($"Book copy '{this.CopyId}' is already not available!");
            }
            
            this.CheckedOut= true;
            this.IsAvailable=false;
        }

        public void ReturnBookCopy()
        {
            if (this.IsAvailable)
            {
                throw new LibraryCatalogDomainException($"Book copy '{this.CopyId}' is already available in library!");
            }

            this.CheckedOut= false;
            this.IsAvailable=true;
        }

    }
}
