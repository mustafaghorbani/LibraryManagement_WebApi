using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Repositories;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace LibraryManagement.Repository.Handlers
{
    public class GetDailyReportQueryHandler : IRequestHandler<GetDailyReportQuery, List<DailyReportDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetDailyReportQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this._unitOfWork=unitOfWork;
            this._mapper = mapper;
        }

        async Task<List<DailyReportDto>> IRequestHandler<GetDailyReportQuery, List<DailyReportDto>>.Handle(GetDailyReportQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.BookTransactionRepository.GetDailyReport();
        }
    }
}
