using LibraryManagement.Repository.Commands;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class SetBookReturnedCommandHandler : IRequestHandler<SetBookReturnedCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SetBookReturnedCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        Task<Unit> IRequestHandler<SetBookReturnedCommand, Unit>.Handle(SetBookReturnedCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.BookTransactionRepository.SetBookReturned(request.isbn, request.memberId);
            _unitOfWork.CommitAsync();
            return Task.FromResult(Unit.Value);
        }
    }
}
