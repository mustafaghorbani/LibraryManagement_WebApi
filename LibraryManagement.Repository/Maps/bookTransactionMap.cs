using AutoMapper;
using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository.Dto;

namespace LibraryManagement.Repository.Maps
{
    public class bookTransactionMap : Profile
    {
        public bookTransactionMap()
        {
            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.BorrowDate));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.BorrowDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.ReturnDate, opt => opt.MapFrom(src => src.ReturnDate));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.ReturnDate, opt => opt.MapFrom(src => src.ReturnDate));

            CreateMap<BookTransactionsDto, BookTransaction>().ForMember(dest => dest.DueTo, opt => opt.MapFrom(src => src.DueTo));
            CreateMap<BookTransaction, BookTransactionsDto>().ForMember(dest => dest.DueTo, opt => opt.MapFrom(src => src.DueTo));
        }
    }
}
