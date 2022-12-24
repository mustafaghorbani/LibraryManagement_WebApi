using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Dto;

namespace LibraryManagement.Repository.Repositories
{
    public interface IBookTransactionRepository : IRepository<BookTransaction>
    {
        Task<List<DailyReportDto>> GetDailyReport();

        Task SetBookReturned(string isbn, int memberId);
    }
}
