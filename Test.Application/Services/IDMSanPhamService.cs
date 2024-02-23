using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IDMSanPhamService
    {
        List<DMSanPhamDto> GetAll();// lấy toàn bộ danh sách
        DMSanPhamDto Get(Guid id);
        bool Add(DMSanPhamDto dmspDto);
        bool Update(DMSanPhamDto dmspDto);
        bool Delete(Guid id);
    }
}
