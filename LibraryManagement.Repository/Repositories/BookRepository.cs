using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;

namespace LibraryManagement.Repository.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> SearchBooks(string title, string author, string isbn)
        {
            var Books = _context.Books
                .Where(x =>
                (string.IsNullOrEmpty(x.Title) || x.Title.Contains(title))
                || (string.IsNullOrEmpty(x.Author) || x.Author.Contains(author))
                || (string.IsNullOrEmpty(x.ISBN) || x.ISBN == isbn))
                .ToList();
            return Books;
        }
    }
}
