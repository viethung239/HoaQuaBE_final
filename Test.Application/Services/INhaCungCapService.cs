using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;

namespace Test.Application.Services
{
    public interface INhaCungCapService
    {
        List<NhaCungCapDto> GetAll();// lấy toàn bộ danh sách
        NhaCungCapDto Get(Guid id);
        bool Add(NhaCungCapDto khoDto);
        bool Update(NhaCungCapDto khoDto);
        bool Delete(Guid id);
    }
}
