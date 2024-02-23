using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;

namespace Test.Application.Services
{
    public interface IUserService
    {
        List<UserDto> GetAll();// lấy toàn bộ danh sách
        UserDto Get(Guid id);
        bool Add(UserDto userDto);
        bool Update(UserDto userDto);
        bool Delete(Guid id);
        RoleDto GetRoleByUserName(string userName);
    }
}
