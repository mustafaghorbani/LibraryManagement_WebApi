using LibraryManagement.Repository.Dto;
using MediatR;

namespace LibraryManagement.Repository.Queries
{
    public record GetDailyReportQuery : IRequest<List<DailyReportDto>>;
}
