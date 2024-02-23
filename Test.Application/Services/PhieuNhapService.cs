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
    public class PhieuNhapService : IPhieuNhapService
    {
        private readonly IPhieuNhapRepo _khoctRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuNhapService(IPhieuNhapRepo khoctRepo, IMapper mapper)
        {
            _khoctRepo = khoctRepo;
            _mapper = mapper;
        }
        public List<PhieuNhapDto> GetAll()
        {
            return _mapper.Map<List<PhieuNhapDto>>(_khoctRepo.GetAll());
        }

        public PhieuNhapDto Get(Guid id)
        {
            return _mapper.Map<PhieuNhapDto>(_khoctRepo.Get(id));
        }

        public bool Add(PhieuNhapDto khoctDto)
        {
            return _khoctRepo.Add(_mapper.Map<PhieuNhap>(khoctDto));
        }

        public bool Update(PhieuNhapDto khoctDto)
        {
            return _khoctRepo.Update(_mapper.Map<PhieuNhap>(khoctDto));
        }

        public bool Delete(Guid id)
        {
            return _khoctRepo.Delete(id);
        }
    }
}
