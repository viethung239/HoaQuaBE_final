using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;
using Test.Domain.Entities;
using Test.Domain.Repositories;

namespace Test.Application.Services
{
    public class RoleService :IRoleService
    {
        private readonly IRoleRepo _roleRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public RoleService(IRoleRepo roleRepo, IMapper mapper)
        {
            _roleRepo = roleRepo;
            _mapper = mapper;
        }
        public List<RoleDto> GetAll()
        {
            return _mapper.Map<List<RoleDto>>(_roleRepo.GetAll());
        }

        public RoleDto Get(Guid id)
        {
            return _mapper.Map<RoleDto>(_roleRepo.Get(id));
        }

        public bool Add(RoleDto roleDto)
        {
            return _roleRepo.Add(_mapper.Map<Role>(roleDto));
        }

        public bool Update(RoleDto roleDto)
        {
            return _roleRepo.Update(_mapper.Map<Role>(roleDto));
        }

        public bool Delete(Guid id)
        {
            return _roleRepo.Delete(id);
        }

    }
}
