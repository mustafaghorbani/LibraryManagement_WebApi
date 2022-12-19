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
    public class MemberMap:Profile
    {
        public MemberMap()
        {
            CreateMap<MemberDto, Member>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Member, MemberDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<MemberDto, Member>().ForMember(dest => dest.MemberName, opt => opt.MapFrom(src => src.MemberName));
            CreateMap<Member, MemberDto>().ForMember(dest => dest.MemberName, opt => opt.MapFrom(src => src.MemberName));

            CreateMap<MemberDto, Member>().ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId));
            CreateMap<Member, MemberDto>().ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId));


        }
    }
}
