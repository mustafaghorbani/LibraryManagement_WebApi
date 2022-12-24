using AutoMapper;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class SearchBookQueryHandler : IRequestHandler<SearchBookQuery, List<BookDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SearchBookQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<BookDto>> Handle(SearchBookQuery request, CancellationToken cancellationToken)
        {
            var books = await _unitOfWork.BookRepository.SearchBooks(request.title, request.author, request.isbn);
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
