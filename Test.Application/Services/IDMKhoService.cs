using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IDMKhoService
    {
        List<DMKhoDto> GetAll();// lấy toàn bộ danh sách
        DMKhoDto Get(Guid id);
        bool Add(DMKhoDto dmkDto);
        bool Update(DMKhoDto dmkDto);
        bool Delete(Guid id);
    }

}
