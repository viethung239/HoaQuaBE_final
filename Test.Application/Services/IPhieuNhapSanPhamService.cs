using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IPhieuNhapSanPhamService
    {
        List<PhieuNhapSanPhamDto> GetAll();// lấy toàn bộ danh sách
        PhieuNhapSanPhamDto Get(Guid id);
        bool Add(PhieuNhapSanPhamDto khoDto);
        bool Update(PhieuNhapSanPhamDto khoDto);
        bool Delete(Guid id);
    }
}
