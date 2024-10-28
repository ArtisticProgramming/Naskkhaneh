using LibraryCatalog.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public class Publisher : ValueObject
    {
        public Publisher(string name, string? city, string? address, string? phoneNumber)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new LibraryCatalogDomainException("Publisher Name is not correct.");
            }

            Name=name;
            City=city;
            Address=address;
            PhoneNumber=phoneNumber;
        }

        public string Name { get; private set; }
        public string? City { get; private set; }
        public string? Address { get; private set; }
        public string? PhoneNumber { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
