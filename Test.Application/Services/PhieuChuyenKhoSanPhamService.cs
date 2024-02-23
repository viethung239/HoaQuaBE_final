using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Domain.Entities;
using Test.Domain.Repositories;
using Test.Infrastructure.Repositories;

namespace Test.Application.Services
{
    public class PhieuChuyenKhoSanPhamService :IPhieuChuyenKhoSanPhamService
    {
        private readonly IPhieuChuyenKhoSanPham _nccRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuChuyenKhoSanPhamService(IPhieuChuyenKhoSanPham nccRepo, IMapper mapper)
        {
            _nccRepo = nccRepo;
            _mapper = mapper;
        }
        public List<PhieuChuyenKhoSanPhamDto> GetAll()
        {
            return _mapper.Map<List<PhieuChuyenKhoSanPhamDto>>(_nccRepo.GetAll());
        }

        public PhieuChuyenKhoSanPhamDto Get(Guid id)
        {
            return _mapper.Map<PhieuChuyenKhoSanPhamDto>(_nccRepo.Get(id));
        }

        public bool Add(PhieuChuyenKhoSanPhamDto nccRepo)
        {
            return _nccRepo.Add(_mapper.Map<PhieuChuyenKhoSanPham>(nccRepo));
        }

        public bool Update(PhieuChuyenKhoSanPhamDto nccRepo)
        {
            return _nccRepo.Update(_mapper.Map<PhieuChuyenKhoSanPham>(nccRepo));
        }

        public bool Delete(Guid id)
        {
            return _nccRepo.Delete(id);
        }
    }
}
