using LibraryManagement.Domain.Domain;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetSearchBookQuery(string title, string isbn) : IRequest<List<Book>>;
}
