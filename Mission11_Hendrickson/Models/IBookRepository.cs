namespace Mission11_Hendrickson.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }

}
