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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            BookRepository = new BookRepository(this._context);
            MemberRepository= new MemberRepository(this._context);
            BookTransactionRepository= new BookTransactionRepository(this._context);    
        }

        public IBookRepository BookRepository { get; private set; }

        public IRepository<Member> MemberRepository { get; private set; }

        public IBookTransactionRepository BookTransactionRepository { get; private set; }

        public async Task<bool> Save() => await _context.SaveChangesAsync() > 0;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
