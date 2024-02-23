using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IPhieuXuatService
    {
        List<PhieuXuatDto> GetAll();// lấy toàn bộ danh sách
        PhieuXuatDto Get(Guid id);
        bool Add(PhieuXuatDto khoDto);
        bool Update(PhieuXuatDto khoDto);
        bool Delete(Guid id);
    }
}
