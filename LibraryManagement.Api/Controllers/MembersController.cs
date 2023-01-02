using LibraryManagement.Repository.Commands;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MembersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [Route("GetMembers")]
        [HttpGet]
        public async Task<List<MemberDto>> GetMembersAsync()
        {
            return await _mediator.Send(new GetMembersQuery());
        }

        [Route("Create")]
        [HttpPost]
        public async Task CreateAsync(CreateMemberCommand command)
        {
            await _mediator.Send(new CreateMemberCommand(command.memberName));
        }
    }
}
