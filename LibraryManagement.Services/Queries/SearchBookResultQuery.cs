namespace LibraryManagement.Repository.Queries
{
    public class SearchBookResultQuery
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }


    }
}
