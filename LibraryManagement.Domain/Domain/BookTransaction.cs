using LibraryManagement.Infrastructure.Entity;
using LibraryManagement.Infrastructure.Helpers;

namespace LibraryManagement.Domain.Domain
{
    public class BookTransaction : BaseEntity<Guid, string>
    {

        public BookTransaction()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            DueTo = CommonHelper.AddBusinessDays(DateTime.Now, 30);
        }
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ISBN
        /// FK
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the MemberId
        /// FK
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the DueTo
        /// </summary>
        public DateTime DueTo { get; set; }

        /// <summary>
        /// Gets or sets the ReturnDate
        /// </summary>
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the Book
        /// </summary>
        public virtual Book Book { get; set; }

        /// <summary>
        /// Gets or sets the Member
        /// </summary>
        public virtual Member Member { get; set; }
    }
}
