using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IPhieuXuatSanPhamService
    {
        List<PhieuXuatSanPhamDto> GetAll();// lấy toàn bộ danh sách
        PhieuXuatSanPhamDto Get(Guid id);
        bool Add(PhieuXuatSanPhamDto pxspDto);
        bool Update(PhieuXuatSanPhamDto pxspDto);
        bool Delete(Guid id);
    }
}
