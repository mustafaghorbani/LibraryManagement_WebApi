using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record CreateBookTransaction(Guid bookId, int memberId, DateTime dueDate) : IRequest<int>;
}
