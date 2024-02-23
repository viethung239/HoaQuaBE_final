using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IDonHangService
    {
        List<DonHangDto> GetAll();// lấy toàn bộ danh sách
        DonHangDto Get(Guid id);
        bool Add(DonHangDto donhangDto);
        bool Update(DonHangDto donhangDto);
        bool Delete(Guid id);
    }
}
