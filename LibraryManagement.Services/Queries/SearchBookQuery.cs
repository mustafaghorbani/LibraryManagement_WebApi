using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record SearchBookQuery(string? title, string? author, string? isbn) : IRequest<List<BookDto>>;
}
