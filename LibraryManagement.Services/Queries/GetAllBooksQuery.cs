using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetAllBooksQuery() : IRequest<List<BookDto>>;
}
