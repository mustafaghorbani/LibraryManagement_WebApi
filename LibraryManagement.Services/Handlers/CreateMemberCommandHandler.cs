using LibraryManagement.Repository.Commands;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateMemberCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.MemberRepository.Add(new Domain.Domain.Member() { MemberName = request.memberName });
            await _unitOfWork.CommitAsync();

            return Unit.Value;
        }
    }
}
