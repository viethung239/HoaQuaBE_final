using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IDMNSanPhamService
    {
        List<DMNSanPhamDto> GetAll();// lấy toàn bộ danh sách
        DMNSanPhamDto Get(Guid id);
        bool Add(DMNSanPhamDto dmnDto);
        bool Update(DMNSanPhamDto dmnDto);
        bool Delete(Guid id);
    }
}
