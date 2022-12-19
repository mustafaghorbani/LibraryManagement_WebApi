using AutoMapper;
using LibraryManagement.Domain.Domain;
using LibraryManagement.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Maps
{
    public class BookMap : Profile
    {
        public BookMap()
        {
            CreateMap<BookDto, Book>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Book, BookDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<BookDto, Book>().ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
            CreateMap<Book, BookDto>().ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

            CreateMap<BookDto, Book>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author));
            CreateMap<Book, BookDto>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author));

            CreateMap<BookDto, Book>().ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN));
            CreateMap<Book, BookDto>().ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN));

            CreateMap<BookDto, Book>().ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable));
            CreateMap<Book, BookDto>().ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable));

            CreateMap<BookDto, Book>().ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
            CreateMap<Book, BookDto>().ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
        }
    }
}
