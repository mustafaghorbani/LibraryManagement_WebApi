using LibraryManagement.Repository.Commands;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class CreateBookTransactionCommandHandler : IRequestHandler<CreateBookTransactionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookTransactionCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        Task<Unit> IRequestHandler<CreateBookTransactionCommand, Unit>.Handle(CreateBookTransactionCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.BookTransactionRepository.Add(new Domain.Domain.BookTransaction() { ISBN = request.isbn, MemberId = request.memberId });
            _unitOfWork.CommitAsync();

            return Task.FromResult(Unit.Value);
        }
    }
}
