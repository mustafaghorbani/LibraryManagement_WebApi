using LibraryManagement.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Domain
{
    public partial class Book : BaseEntity<int,string>
    {
        public Book()
        {
            BookTransactions=new HashSet<BookTransaction>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; } //978-0-393-04002-9 

        public string Description { get; set; }

        public bool IsAvailable { get; set; }

        public virtual ICollection<BookTransaction> BookTransactions { get; set; }

    }
}
