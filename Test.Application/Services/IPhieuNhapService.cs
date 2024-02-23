using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IPhieuNhapService
    {
        List<PhieuNhapDto> GetAll();// lấy toàn bộ danh sách
        PhieuNhapDto Get(Guid id);
        bool Add(PhieuNhapDto khoDto);
        bool Update(PhieuNhapDto khoDto);
        bool Delete(Guid id);
    }
}
