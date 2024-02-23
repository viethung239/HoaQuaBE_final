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
    public class DonHangService : IDonHangService
    {
        private readonly IDonHangRepo _dhRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public DonHangService(IDonHangRepo dhRepo, IMapper mapper)
        {
            _dhRepo = dhRepo;
            _mapper = mapper;
        }
        public List<DonHangDto> GetAll()
        {
            return _mapper.Map<List<DonHangDto>>(_dhRepo.GetAll());
        }

        public DonHangDto Get(Guid id)
        {
            return _mapper.Map<DonHangDto>(_dhRepo.Get(id));
        }

        public bool Add(DonHangDto dhto)
        {
            return _dhRepo.Add(_mapper.Map<DonHang>(dhto));
        }

        public bool Update(DonHangDto dhto)
        {
            return _dhRepo.Update(_mapper.Map<DonHang>(dhto));
        }

        public bool Delete(Guid id)
        {
            return _dhRepo.Delete(id);
        }
    }
}
