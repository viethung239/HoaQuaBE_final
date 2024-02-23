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
    public class PhieuChuyenKhoService :IPhieuChuyenKhoService
    {
        private readonly IPhieuChuyenKhoRepo _nccRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuChuyenKhoService(IPhieuChuyenKhoRepo nccRepo, IMapper mapper)
        {
            _nccRepo = nccRepo;
            _mapper = mapper;
        }
        public List<PhieuChuyenKhoDto> GetAll()
        {
            return _mapper.Map<List<PhieuChuyenKhoDto>>(_nccRepo.GetAll());
        }

        public PhieuChuyenKhoDto Get(Guid id)
        {
            return _mapper.Map<PhieuChuyenKhoDto>(_nccRepo.Get(id));
        }

        public bool Add(PhieuChuyenKhoDto nccRepo)
        {
            return _nccRepo.Add(_mapper.Map<PhieuChuyenKho>(nccRepo));
        }

        public bool Update(PhieuChuyenKhoDto nccRepo)
        {
            return _nccRepo.Update(_mapper.Map<PhieuChuyenKho>(nccRepo));
        }

        public bool Delete(Guid id)
        {
            return _nccRepo.Delete(id);
        }
    }
}
