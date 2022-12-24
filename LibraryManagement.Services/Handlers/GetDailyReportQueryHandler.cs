using AutoMapper;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class GetDailyReportQueryHandler : IRequestHandler<GetDailyReportQuery, List<DailyReportDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetDailyReportQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        async Task<List<DailyReportDto>> IRequestHandler<GetDailyReportQuery, List<DailyReportDto>>.Handle(GetDailyReportQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.BookTransactionRepository.GetDailyReport();
        }
    }
}
