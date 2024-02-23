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
    public class PhieuXuatSanPhamService : IPhieuXuatSanPhamService
    {
        private readonly IPhieuXuatSanPhamRepo _khoctRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuXuatSanPhamService(IPhieuXuatSanPhamRepo khoctRepo, IMapper mapper)
        {
            _khoctRepo = khoctRepo;
            _mapper = mapper;
        }
        public List<PhieuXuatSanPhamDto> GetAll()
        {
            return _mapper.Map<List<PhieuXuatSanPhamDto>>(_khoctRepo.GetAll());
        }

        public PhieuXuatSanPhamDto Get(Guid id)
        {
            return _mapper.Map<PhieuXuatSanPhamDto>(_khoctRepo.Get(id));
        }

        public bool Add(PhieuXuatSanPhamDto khoctDto)
        {
            return _khoctRepo.Add(_mapper.Map<PhieuXuatSanPham>(khoctDto));
        }

        public bool Update(PhieuXuatSanPhamDto khoctDto)
        {
            return _khoctRepo.Update(_mapper.Map<PhieuXuatSanPham>(khoctDto));
        }

        public bool Delete(Guid id)
        {
            return _khoctRepo.Delete(id);
        }
    }
}
