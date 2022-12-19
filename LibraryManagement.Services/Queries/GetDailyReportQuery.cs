using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Queries
{
    public record GetDailyReportQuery : IRequest<List<DailyReportDto>>;
}
