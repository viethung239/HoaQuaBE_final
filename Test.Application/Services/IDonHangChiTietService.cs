using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IDonHangChiTietService
    {
        List<DonHangChiTietDto> GetAll();// lấy toàn bộ danh sách
        DonHangChiTietDto Get(Guid id);
        bool Add(DonHangChiTietDto donhangctDto);
        bool Update(DonHangChiTietDto donhangctDto);
        bool Delete(Guid id);
    }
}
