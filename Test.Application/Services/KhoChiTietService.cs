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
    public class KhoChiTietService : IKhoChiTietService
    {
        private readonly IKhoChiTietRepo _khoctRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public KhoChiTietService(IKhoChiTietRepo khoctRepo, IMapper mapper)
        {
            _khoctRepo = khoctRepo;
            _mapper = mapper;
        }
        public List<KhoChiTietDto> GetAll()
        {
            return _mapper.Map<List<KhoChiTietDto>>(_khoctRepo.GetAll());
        }

        public KhoChiTietDto Get(Guid id)
        {
            return _mapper.Map<KhoChiTietDto>(_khoctRepo.Get(id));
        }

        public bool Add(KhoChiTietDto khoctDto)
        {
            return _khoctRepo.Add(_mapper.Map<KhoChiTiet>(khoctDto));
        }

        public bool Update(KhoChiTietDto khoctDto)
        {
            return _khoctRepo.Update(_mapper.Map<KhoChiTiet>(khoctDto));
        }

        public bool Delete(Guid id)
        {
            return _khoctRepo.Delete(id);
        }
    }
}
