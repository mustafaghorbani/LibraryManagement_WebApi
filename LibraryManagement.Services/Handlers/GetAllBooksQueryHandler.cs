using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository;
using LibraryManagement.Repository.Repositories;
using LibraryManagement.Repository.Dto;
using LibraryManagement.Repository.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace LibraryManagement.Repository.Handlers
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
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
