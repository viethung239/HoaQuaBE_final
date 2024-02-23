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
    public class KhoService : IKhoService
    {
        private readonly IKhoRepo _khoRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public KhoService(IKhoRepo khoRepo, IMapper mapper)
        {
            _khoRepo = khoRepo;
            _mapper = mapper;
        }
        public List<KhoDto> GetAll()
        {
            return _mapper.Map<List<KhoDto>>(_khoRepo.GetAll());
        }

        public KhoDto Get(Guid id)
        {
            return _mapper.Map<KhoDto>(_khoRepo.Get(id));
        }

        public bool Add(KhoDto khoDto)
        {
            return _khoRepo.Add(_mapper.Map<Kho>(khoDto));
        }

        public bool Update(KhoDto khoDto)
        {
            return _khoRepo.Update(_mapper.Map<Kho>(khoDto));
        }

        public bool Delete(Guid id)
        {
            return _khoRepo.Delete(id);
        }
    }
}
