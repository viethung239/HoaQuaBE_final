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
    public class DonHangChiTietService : IDonHangChiTietService
    {
        private readonly IDonHangChiTietRepo _dhRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public DonHangChiTietService(IDonHangChiTietRepo dhRepo, IMapper mapper)
        {
            _dhRepo = dhRepo;
            _mapper = mapper;
        }
        public List<DonHangChiTietDto> GetAll()
        {
            return _mapper.Map<List<DonHangChiTietDto>>(_dhRepo.GetAll());
        }

        public DonHangChiTietDto Get(Guid id)
        {
            return _mapper.Map<DonHangChiTietDto>(_dhRepo.Get(id));
        }

        public bool Add(DonHangChiTietDto dhto)
        {
            return _dhRepo.Add(_mapper.Map<DonHangChiTiet>(dhto));
        }

        public bool Update(DonHangChiTietDto dhto)
        {
            return _dhRepo.Update(_mapper.Map<DonHangChiTiet>(dhto));
        }

        public bool Delete(Guid id)
        {
            return _dhRepo.Delete(id);
        }
    }
}
