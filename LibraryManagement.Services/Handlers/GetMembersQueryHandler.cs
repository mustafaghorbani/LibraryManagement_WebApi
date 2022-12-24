using AutoMapper;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, List<MemberDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetMembersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<List<MemberDto>> Handle(GetMembersQuery request, CancellationToken cancellationToken)
        {
            var members = await _unitOfWork.MemberRepository.GetAll();
            return _mapper.Map<List<MemberDto>>(members);
        }
    }
}
