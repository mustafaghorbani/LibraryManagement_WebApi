using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Commands
{
    public record UpdateBookCommand(int id, string title, string isbn, bool isAvailable) : IRequest<int>;
}
