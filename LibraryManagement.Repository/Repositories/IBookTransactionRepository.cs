using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Repositories
{
    public interface IBookTransactionRepository : IRepository<BookTransaction>
    {
        Task<List<DailyReportDto>> GetDailyReport();

        Task<bool> SetBookReturned(string isbn, int memberId);
    }

}
