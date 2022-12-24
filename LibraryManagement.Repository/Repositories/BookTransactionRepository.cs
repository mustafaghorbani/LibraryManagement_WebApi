using LibraryManagement.Domain.Domain;
using LibraryManagement.Infrastructure.Helpers;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Dto;

namespace LibraryManagement.Repository.Repositories
{
    public class BookTransactionRepository : Repository<BookTransaction>, IBookTransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public BookTransactionRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<DailyReportDto>> GetDailyReport()
        {
            //Daily report will be used by Librarian to follow upcoming or late due dates of books.
            //If the book has penalty for a late due date, must be also shown on this report screen. Upcoming due dates will be listed for last two days.
            var query = from BT in _context.BookTransactions
                        join B in _context.Books on BT.ISBN equals B.ISBN
                        join M in _context.Members on BT.MemberId equals M.MemberId
                        where BT.ReturnDate == null && BT.DueTo >= DateTime.Now.AddDays(-2)
                        select new DailyReportDto()
                        {
                            BookTitle = B.Title,
                            ISBN = B.ISBN,
                            MemberId = BT.MemberId,
                            MemberName = M.MemberName,
                            TransactionId = BT.Id,
                            Penalty = CommonHelper.CalculatePenalty(Convert.ToInt32((DateTime.Now - BT.DueTo).TotalDays), 0.20),
                        };

            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public async Task SetBookReturned(string isbn, int memberId)
        {
            var bookTransaction = _context.BookTransactions.Where(x => x.ISBN == isbn && x.MemberId == memberId && x.ReturnDate == null).FirstOrDefault();
            bookTransaction.ReturnDate = DateTime.Now;
            _context.Update(bookTransaction);
            await _context.SaveChangesAsync();
        }
    }
}
