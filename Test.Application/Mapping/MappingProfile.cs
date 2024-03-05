using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;
using Test.Domain.Entities;

namespace Test.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
         
            CreateMap<User, UserDto>().ReverseMap();     
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<ChiNhanh, ChiNhanhDto>().ReverseMap();
            CreateMap<SanPham,SanPhamDto>().ReverseMap();
            CreateMap<DMSanPham, DMSanPhamDto>().ReverseMap();
            CreateMap<DMNhomSanPham, DMNSanPhamDto>().ReverseMap();
            CreateMap<Kho, KhoDto>().ReverseMap();
            CreateMap<DMKho, DMKhoDto>().ReverseMap();
            CreateMap<KhoChiTiet, KhoChiTietDto>().ReverseMap();    
            CreateMap<NhaCungCap, NhaCungCapDto>().ReverseMap();
            CreateMap<DonHang, DonHangDto>().ReverseMap();
            CreateMap<DonHangChiTiet, DonHangChiTietDto>().ReverseMap();
           
        }
    }
}
