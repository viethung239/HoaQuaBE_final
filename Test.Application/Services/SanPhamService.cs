using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Dto.User;
using Test.Domain.Entities;
using Test.Domain.Repositories;

namespace Test.Application.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepo _spRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public SanPhamService(ISanPhamRepo spRepo, IMapper mapper)
        {
            _spRepo = spRepo;
            _mapper = mapper;
        }
        public List<SanPhamDto> GetAll()
        {
            return _mapper.Map<List<SanPhamDto>>(_spRepo.GetAll());
        }

        public SanPhamDto Get(Guid id)
        {
            return _mapper.Map<SanPhamDto>(_spRepo.Get(id));
        }

        public bool Add(SanPhamDto spDto)
        {
            return _spRepo.Add(_mapper.Map<SanPham>(spDto));
        }

        public bool Update(SanPhamDto spDto)
        {
            return _spRepo.Update(_mapper.Map<SanPham>(spDto));
        }

        public bool Delete(Guid id)
        {
            return _spRepo.Delete(id);
        }
    }
}
