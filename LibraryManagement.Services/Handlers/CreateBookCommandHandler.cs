using LibraryManagement.Repository.Commands;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        Task<Unit> IRequestHandler<CreateBookCommand, Unit>.Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            _unitOfWork.BookRepository.Add(new Domain.Domain.Book() { Title = request.title, ISBN = request.isbn, Author = request.author, Description = request.desicription });
            _unitOfWork.CommitAsync();
            return Task.FromResult(Unit.Value);
        }
    }
}
