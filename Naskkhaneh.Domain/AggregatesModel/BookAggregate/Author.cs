
namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public class Author : ValueObject
    {
        public Author(string fullName, DateTime? birthDate, string birthCity)
        {
            FullName=fullName;
        }

        public  string FullName { get; private  set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FullName;
        }
    }
}
