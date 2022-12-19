using LibraryManagement.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Domain
{
    public class BookTransaction : BaseEntity<int, string>
    {
        public int Id { get; set; }

        //FK
        public string ISBN { get; set; }
        public int MemberId { get; set; }


        public DateTime DueTo { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }


    }
}
