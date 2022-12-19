using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        IRepository<Member> MemberRepository { get; }
        IBookTransactionRepository BookTransactionRepository { get; }

        Task<bool> Save();
    }
}
