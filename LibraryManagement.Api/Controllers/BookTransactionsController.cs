using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Commands;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookTransactionsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [Route("BorrowBook")]
        [HttpPost]
        public async Task BorrowBookAsync(CreateBookTransactionCommand command)
        {
            await _mediator.Send(new CreateBookTransactionCommand(command.isbn, command.memberId));
        }

        [Route("DailyReport")]
        [HttpGet]
        public async Task<List<DailyReportDto>> DailyReportAsync()
        {
            return await _mediator.Send(new GetDailyReportQuery());
        }

        [Route("SetBookReturned")]
        [HttpPost]
        public async Task SetBookReturnedAsync(SetBookReturnedCommand command)
        {
            await _mediator.Send(new SetBookReturnedCommand(command.isbn, command.memberId));
        }

    }
}
