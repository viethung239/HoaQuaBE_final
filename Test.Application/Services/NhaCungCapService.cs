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
    public class NhaCungCapService : INhaCungCapService
    {
        private readonly INhaCungCapRepo _nccRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public NhaCungCapService(INhaCungCapRepo nccRepo, IMapper mapper)
        {
            _nccRepo = nccRepo;
            _mapper = mapper;
        }
        public List<NhaCungCapDto> GetAll()
        {
            return _mapper.Map<List<NhaCungCapDto>>(_nccRepo.GetAll());
        }

        public NhaCungCapDto Get(Guid id)
        {
            return _mapper.Map<NhaCungCapDto>(_nccRepo.Get(id));
        }

        public bool Add(NhaCungCapDto nccRepo)
        {
            return _nccRepo.Add(_mapper.Map<NhaCungCap>(nccRepo));
        }

        public bool Update(NhaCungCapDto nccRepo)
        {
            return _nccRepo.Update(_mapper.Map<NhaCungCap>(nccRepo));
        }

        public bool Delete(Guid id)
        {
            return _nccRepo.Delete(id);
        }
    }
}
