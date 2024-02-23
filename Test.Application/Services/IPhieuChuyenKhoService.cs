using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IPhieuChuyenKhoService
    {
        List<PhieuChuyenKhoDto> GetAll();// lấy toàn bộ danh sách
        PhieuChuyenKhoDto Get(Guid id);
        bool Add(PhieuChuyenKhoDto roleDto);
        bool Update(PhieuChuyenKhoDto roleDto);
        bool Delete(Guid id);
    }
}
