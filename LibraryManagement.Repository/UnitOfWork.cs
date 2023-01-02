using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Repositories;

namespace LibraryManagement.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            BookRepository = new BookRepository(this._context);
            MemberRepository = new MemberRepository(this._context);
            BookTransactionRepository = new BookTransactionRepository(this._context);
        }

        public IBookRepository BookRepository { get; private set; }

        public IRepository<Member> MemberRepository { get; private set; }

        public IBookTransactionRepository BookTransactionRepository { get; private set; }

        public void Commit() => _context.SaveChanges();

        public async Task CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
