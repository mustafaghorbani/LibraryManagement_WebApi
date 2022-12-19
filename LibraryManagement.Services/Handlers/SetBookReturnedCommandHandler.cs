using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Repositories;
using LibraryManagement.Repository.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return Task.FromResult(Unit.Value);
        }
    }
}
