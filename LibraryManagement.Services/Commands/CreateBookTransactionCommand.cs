using MediatR;

namespace LibraryManagement.Repository.Commands
{
    public record CreateBookTransactionCommand(string isbn, int memberId) : IRequest;

}
