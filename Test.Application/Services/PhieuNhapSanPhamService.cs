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
    public class PhieuNhapSanPhamService : IPhieuNhapSanPhamService
    {
        private readonly IPhieuNhapSanPhamRepo _khoctRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuNhapSanPhamService(IPhieuNhapSanPhamRepo khoctRepo, IMapper mapper)
        {
            _khoctRepo = khoctRepo;
            _mapper = mapper;
        }
        public List<PhieuNhapSanPhamDto> GetAll()
        {
            return _mapper.Map<List<PhieuNhapSanPhamDto>>(_khoctRepo.GetAll());
        }

        public PhieuNhapSanPhamDto Get(Guid id)
        {
            return _mapper.Map<PhieuNhapSanPhamDto>(_khoctRepo.Get(id));
        }

        public bool Add(PhieuNhapSanPhamDto khoctDto)
        {
            return _khoctRepo.Add(_mapper.Map<PhieuNhapSanPham>(khoctDto));
        }

        public bool Update(PhieuNhapSanPhamDto khoctDto)
        {
            return _khoctRepo.Update(_mapper.Map<PhieuNhapSanPham>(khoctDto));
        }

        public bool Delete(Guid id)
        {
            return _khoctRepo.Delete(id);
        }
    }
}
