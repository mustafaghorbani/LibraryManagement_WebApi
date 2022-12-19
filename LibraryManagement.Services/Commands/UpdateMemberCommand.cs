using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Commands
{
    public record UpdateMemberCommand(int id, string memberName) : IRequest<int>;
}
