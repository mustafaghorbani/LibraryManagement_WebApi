using AutoMapper;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _unitOfWork.BookRepository.GetWhere(w => w.IsActive == true);
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
