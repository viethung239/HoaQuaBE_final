using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IKhoService
    {
        List<KhoDto> GetAll();// lấy toàn bộ danh sách
        KhoDto Get(Guid id);
        bool Add(KhoDto khoDto);
        bool Update(KhoDto khoDto);
        bool Delete(Guid id);
    }
}
