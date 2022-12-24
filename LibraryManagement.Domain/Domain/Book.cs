using LibraryManagement.Infrastructure.Entity;

namespace LibraryManagement.Domain.Domain
{
    public partial class Book : BaseEntity<Guid, string>
    {
        public Book()
        {
            Id = Guid.NewGuid();
            BookTransactions = new HashSet<BookTransaction>();
            CreatedDate = DateTime.Now;
            IsActive = true;
            IsAvailable = true;
        }

        /// <summary>
        ///  Gets or sets the Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///  Gets or sets the Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        ///  Gets or sets the ISBN
        ///  sample: 978-0-393-04002-9 
        /// </summary>
        public string ISBN { get; set; }

        /// <summary> 
        ///  Gets or sets the Description
        /// </summary>
        public string? Description { get; set; }


        /// <summary>
        ///  Gets or sets the IsAvailable
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        ///  Gets or sets the BookTransactions
        /// </summary>
        public virtual ICollection<BookTransaction> BookTransactions { get; set; }

    }
}
