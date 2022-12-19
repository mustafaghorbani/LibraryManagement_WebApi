using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Dto
{
    public class MemberDto
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
