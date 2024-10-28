using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Domain.Exceptions
{
    public class LibraryCatalogDomainException : Exception
    {
        public LibraryCatalogDomainException()
        { }

        public LibraryCatalogDomainException(string message)
            : base(message)
        { }

        public LibraryCatalogDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
