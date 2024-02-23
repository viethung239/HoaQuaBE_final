using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface IKhoChiTietService
    {
        List<KhoChiTietDto> GetAll();// lấy toàn bộ danh sách
        KhoChiTietDto Get(Guid id);
        bool Add(KhoChiTietDto khochitietDto);
        bool Update(KhoChiTietDto khochitietDto);
        bool Delete(Guid id);
    }
}
