namespace LibraryManagement.Repository.Dto
{
    public class BookTransactionsDto
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public int MemberId { get; set; }

        public string BookTitle { get; set; }

        public string ISBN { get; set; }

        public string MemberName { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueTo { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
