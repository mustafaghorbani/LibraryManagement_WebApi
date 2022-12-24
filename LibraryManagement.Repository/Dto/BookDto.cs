﻿namespace LibraryManagement.Repository.Dto
{
    public class BookDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Description { get; set; }

        public bool IsAvailable { get; set; }

        public bool IsActive { get; set; }

    }
}
