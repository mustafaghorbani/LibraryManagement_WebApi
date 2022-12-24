using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetbookTransactionsQuery : IRequest<List<BookTransactionsDto>>;
}
