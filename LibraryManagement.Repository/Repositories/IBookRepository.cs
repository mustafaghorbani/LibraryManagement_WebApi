using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> SearchBooks(string title, string author, string isbn);
    }
}
