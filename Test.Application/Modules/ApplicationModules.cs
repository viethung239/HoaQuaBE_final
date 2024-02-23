using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Mapping;
using Test.Application.Services;
using Test.Domain.Repositories;
using Test.Infrastructure.Modules;

namespace Test.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddInfrastructureModule();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
         
            services.AddScoped<IUserService, UserService>();      
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IChiNhanhService, ChiNhanhService>();
            services.AddScoped<ISanPhamService, SanPhamService>();
            services.AddScoped<IDMSanPhamService, DMSanPhamService>();
            services.AddScoped<IDMNSanPhamService, DMNSanPhamService>();
            services.AddScoped<IKhoService, KhoService>();
            services.AddScoped<IDMKhoService, DMKhoService>();
            services.AddScoped<IKhoChiTietService, KhoChiTietService>();
            services.AddScoped<INhaCungCapService, NhaCungCapService>();
            services.AddScoped<IDonHangService, DonHangService>();
            services.AddScoped<IDonHangChiTietService, DonHangChiTietService>();
            services.AddScoped<IPhieuNhapService, PhieuNhapService>();
            services.AddScoped<IPhieuXuatService, PhieuXuatService>();
            services.AddScoped<IPhieuNhapSanPhamService, PhieuNhapSanPhamService>();
            services.AddScoped<IPhieuXuatSanPhamService, PhieuXuatSanPhamService>();
            services.AddScoped<IPhieuChuyenKhoService, PhieuChuyenKhoService>();
            services.AddScoped<IPhieuChuyenKhoSanPhamService, PhieuChuyenKhoSanPhamService>();
            return services;
        }
    }
}
