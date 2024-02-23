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
    public class DMNSanPhamService : IDMNSanPhamService
    {
        private readonly IDMNSanPhamRepo _dmnRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public DMNSanPhamService(IDMNSanPhamRepo dmnRepo, IMapper mapper)
        {
            _dmnRepo = dmnRepo;
            _mapper = mapper;
        }
        public List<DMNSanPhamDto> GetAll()
        {
            return _mapper.Map<List<DMNSanPhamDto>>(_dmnRepo.GetAll());
        }

        public DMNSanPhamDto Get(Guid id)
        {
            return _mapper.Map<DMNSanPhamDto>(_dmnRepo.Get(id));
        }

        public bool Add(DMNSanPhamDto dmnDto)
        {
            return _dmnRepo.Add(_mapper.Map<DMNhomSanPham>(dmnDto));
        }

        public bool Update(DMNSanPhamDto dmnDto)
        {
            return _dmnRepo.Update(_mapper.Map<DMNhomSanPham>(dmnDto));
        }

        public bool Delete(Guid id)
        {
            return _dmnRepo.Delete(id);
        }

    }
}
