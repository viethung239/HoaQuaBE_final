using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;
using Test.Domain.Entities;
using Test.Domain.Repositories;
using Test.Infrastructure.Repositories;

namespace Test.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        private readonly IRoleRepo _roleRepo;
       
        public UserService(IUserRepo userRepo, IMapper mapper, IRoleRepo roleRepo)
        {
            _userRepo = userRepo;
            _mapper = mapper;
            _roleRepo = roleRepo;
        }
        public RoleDto GetRoleByUserName(string userName)
        {
            var userRole = _userRepo.GetAll()
         .Where(u => u.UserName == userName)
        .Join(_roleRepo.GetAll(), u => u.RoleId, r => r.RoleId, (u, r) => r)
      . FirstOrDefault();

            if (userRole != null)
            {
                return ConvertToRoleDto(userRole);
            }

            return null;
        }

   

   
        private static RoleDto ConvertToRoleDto(Role role)
        {
            if (role != null)
            {
                return new RoleDto
                {
                    TenQuyen = role.TenQuyen,
                    // Các trường khác của RoleDto nếu có
                };
            }

            // Trả về một RoleDto mặc định hoặc null tùy vào yêu cầu của bạn
            return null;
        }
        public List<UserDto> GetAll()
        {
            return _mapper.Map<List<UserDto>>(_userRepo.GetAll());
        }

        public UserDto Get(Guid id)
        {
            return _mapper.Map<UserDto>(_userRepo.Get(id));
        }

        public bool Add(UserDto userDto)
        {
            return _userRepo.Add(_mapper.Map<User>(userDto));
        }

        public bool Update(UserDto userDto)
        {
            return _userRepo.Update(_mapper.Map<User>(userDto));
        }

        public bool Delete(Guid id)
        {
            return _userRepo.Delete(id);
        }
      
    }
}
