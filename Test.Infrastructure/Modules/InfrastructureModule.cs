using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Entities;
using Test.Domain.Repositories;
using Test.Infrastructure.Repositories;

namespace Test.Infrastructure.Modules
{
  
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
         
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IRoleRepo, RoleRepo>();        
            services.AddScoped<ISanPhamRepo, SanPhamRepo>();
            services.AddScoped<INhaCungCapRepo, NhaCungCapRepo>();
            services.AddScoped<IKhoChiTietRepo, KhoChiTietRepo>();
            services.AddScoped<IKhoRepo, KhoRepo>();
            services.AddScoped<IDMSanPhamRepo, DMSanPhamRepo>();
            services.AddScoped<IDMNSanPhamRepo, DMNSanPhamRepo>();
            services.AddScoped<IDMKhoRepo, DMKhoRepo>();
            services.AddScoped<IChiNhanhRepo, ChiNhanhRepo>();
            services.AddScoped<IDonHangRepo, DonHangRepo>();
            services.AddScoped<IDonHangChiTietRepo, DonHangChiTietRepo>();
          
            return services;
        }
    }
}
