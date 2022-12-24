using AutoMapper;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;

namespace LibraryManagement.Repository.Handlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetBookByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;

        }
        public async Task<BookDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _unitOfWork.BookRepository.GetById(request.id);
            return _mapper.Map<BookDto>(book);
        }
    }
}
