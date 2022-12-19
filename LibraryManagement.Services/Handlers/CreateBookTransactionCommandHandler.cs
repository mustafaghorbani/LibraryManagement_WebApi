using LibraryManagement.Repository;
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
            return Task.FromResult(Unit.Value);
        }
    }
}
