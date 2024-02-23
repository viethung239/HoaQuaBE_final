using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IRoleService
    {
        List<RoleDto> GetAll();// lấy toàn bộ danh sách
        RoleDto Get(Guid id);
        bool Add(RoleDto roleDto);
        bool Update(RoleDto roleDto);
        bool Delete(Guid id);
    }
}
