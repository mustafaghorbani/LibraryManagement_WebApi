using LibraryManagement.Infrastructure.Entity;

namespace LibraryManagement.Domain.Domain
{
    public class Member : BaseEntity<Guid, string>
    {
        public Member()
        {
            Id = Guid.NewGuid();
            MemberId = GenerateNumber();
            BookTransactions = new HashSet<BookTransaction>();
            CreatedDate = DateTime.Now;
        }

        /// <summary>
        ///  Gets or sets the Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  Gets or sets the MemberId
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        ///  Gets or sets the MemberName
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        ///  Gets or sets the BookTransactions
        /// </summary>
        public virtual ICollection<BookTransaction> BookTransactions { get; set; }


        private int GenerateNumber()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(11111111, 99999999);
        }
    }
}
