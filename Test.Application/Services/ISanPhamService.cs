using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface ISanPhamService
    {
        List<SanPhamDto> GetAll();// lấy toàn bộ danh sách
        SanPhamDto Get(Guid id);
        bool Add(SanPhamDto roleDto);
        bool Update(SanPhamDto roleDto);
        bool Delete(Guid id);
    }
}
