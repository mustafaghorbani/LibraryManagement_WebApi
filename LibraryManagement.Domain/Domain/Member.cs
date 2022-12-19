using LibraryManagement.Infrastructure.Entity;

namespace LibraryManagement.Domain.Domain
{
    public class Member : BaseEntity<int, string>
    {
        public Member()
        {
            MemberId = GenerateNumber();
            BookTransactions=new HashSet<BookTransaction>();
        }

        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public virtual ICollection<BookTransaction> BookTransactions { get; set; }

        private int GenerateNumber()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(11111111, 99999999);
        }
    }
}
