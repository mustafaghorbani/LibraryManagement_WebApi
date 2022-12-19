using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Dto
{
    public class BookTransactionsDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public string MemberName { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueTo { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
