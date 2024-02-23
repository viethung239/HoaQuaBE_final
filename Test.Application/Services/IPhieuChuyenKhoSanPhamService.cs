using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IPhieuChuyenKhoSanPhamService
    {
        List<PhieuChuyenKhoSanPhamDto> GetAll();// lấy toàn bộ danh sách
        PhieuChuyenKhoSanPhamDto Get(Guid id);
        bool Add(PhieuChuyenKhoSanPhamDto roleDto);
        bool Update(PhieuChuyenKhoSanPhamDto roleDto);
        bool Delete(Guid id);
    }
}
