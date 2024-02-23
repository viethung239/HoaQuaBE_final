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
    public class DMSanPhamService : IDMSanPhamService
    {
        private readonly IDMSanPhamRepo _dmspRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public DMSanPhamService(IDMSanPhamRepo dmspRepo, IMapper mapper)
        {
            _dmspRepo = dmspRepo;
            _mapper = mapper;
        }
        public List<DMSanPhamDto> GetAll()
        {
            return _mapper.Map<List<DMSanPhamDto>>(_dmspRepo.GetAll());
        }

        public DMSanPhamDto Get(Guid id)
        {
            return _mapper.Map<DMSanPhamDto>(_dmspRepo.Get(id));
        }

        public bool Add(DMSanPhamDto dmspDto)
        {
            return _dmspRepo.Add(_mapper.Map<DMSanPham>(dmspDto));
        }

        public bool Update(DMSanPhamDto dmspDto)
        {
            return _dmspRepo.Update(_mapper.Map<DMSanPham>(dmspDto));
        }

        public bool Delete(Guid id)
        {
            return _dmspRepo.Delete(id);
        }
    }
}
