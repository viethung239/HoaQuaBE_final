using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Domain.Entities;
using Test.Domain.Repositories;

namespace Test.Application.Services
{
    public class DMKhoService : IDMKhoService
    {
        private readonly IDMKhoRepo _dmkRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public DMKhoService(IDMKhoRepo dmkRepo, IMapper mapper)
        {
            _dmkRepo = dmkRepo;
            _mapper = mapper;
        }
        public List<DMKhoDto> GetAll()
        {
            return _mapper.Map<List<DMKhoDto>>(_dmkRepo.GetAll());
        }

        public DMKhoDto Get(Guid id)
        {
            return _mapper.Map<DMKhoDto>(_dmkRepo.Get(id));
        }

        public bool Add(DMKhoDto dmkDto)
        {
            return _dmkRepo.Add(_mapper.Map<DMKho>(dmkDto));
        }

        public bool Update(DMKhoDto dmkDto)
        {
            return _dmkRepo.Update(_mapper.Map<DMKho>(dmkDto));
        }

        public bool Delete(Guid id)
        {
            return _dmkRepo.Delete(id);
        }
    }
}
