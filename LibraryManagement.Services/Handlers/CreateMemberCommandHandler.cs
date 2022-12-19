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
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateMemberCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        Task<Unit> IRequestHandler<CreateMemberCommand, Unit>.Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {

            _unitOfWork.MemberRepository.Add(new Domain.Domain.Member() { MemberName = request.memberName });
            return Task.FromResult(Unit.Value);
        }
    }
}
