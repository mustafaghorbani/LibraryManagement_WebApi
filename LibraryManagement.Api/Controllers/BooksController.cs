using LibraryManagement.Repository.Commands;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [Route("GetAllBooks")]
        [HttpGet]
        public async Task<List<BookDto>> GetAllBooksAsync()
        {
            return await _mediator.Send(new GetAllBooksQuery());
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<BookDto> GetByIdAsync(Guid id)
        {
            return await _mediator.Send(new GetBookByIdQuery(id));
        }

        [Route("CreateBook")]
        [HttpPost]
        public async Task CreateAsync([FromBody] CreateBookCommand model)
        {
            await _mediator.Send(model);
        }

        [Route("SearchBook")]
        [HttpPost]
        public async Task<List<BookDto>> SearchBookAsync([FromBody] SearchBookQuery query)
        {
            return await _mediator.Send(new SearchBookQuery(query.title, query.author, query.isbn));
        }
    }
}


