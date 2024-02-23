using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IChiNhanhService
    {
        List<ChiNhanhDto> GetAll();// lấy toàn bộ danh sách
        ChiNhanhDto Get(Guid id);
        bool Add(ChiNhanhDto roleDto);
        bool Update(ChiNhanhDto roleDto);
        bool Delete(Guid id);
    }
}
