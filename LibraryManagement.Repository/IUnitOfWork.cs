using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Repositories;

namespace LibraryManagement.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        IRepository<Member> MemberRepository { get; }
        IBookTransactionRepository BookTransactionRepository { get; }

        void Commit();
        Task CommitAsync();
    }
}
