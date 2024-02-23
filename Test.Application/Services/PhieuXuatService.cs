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
    public class PhieuXuatService : IPhieuXuatService
    {
        private readonly IPhieuXuatRepo _khoctRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public PhieuXuatService(IPhieuXuatRepo khoctRepo, IMapper mapper)
        {
            _khoctRepo = khoctRepo;
            _mapper = mapper;
        }
        public List<PhieuXuatDto> GetAll()
        {
            return _mapper.Map<List<PhieuXuatDto>>(_khoctRepo.GetAll());
        }

        public PhieuXuatDto Get(Guid id)
        {
            return _mapper.Map<PhieuXuatDto>(_khoctRepo.Get(id));
        }

        public bool Add(PhieuXuatDto khoctDto)
        {
            return _khoctRepo.Add(_mapper.Map<PhieuXuat>(khoctDto));
        }

        public bool Update(PhieuXuatDto khoctDto)
        {
            return _khoctRepo.Update(_mapper.Map<PhieuXuat>(khoctDto));
        }

        public bool Delete(Guid id)
        {
            return _khoctRepo.Delete(id);
        }
    }
}
