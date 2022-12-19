using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Dto
{
    public class SearchBooksDto
    {
        public SearchBooksDto(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
