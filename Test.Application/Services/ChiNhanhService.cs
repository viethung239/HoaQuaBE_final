using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto.User;
using Test.Domain.Entities;
using Test.Domain.Repositories;

namespace Test.Application.Services
{
    public class ChiNhanhService : IChiNhanhService
    {
        private readonly IChiNhanhRepo _cnRepo; //gọi thông qua Interface
        private readonly IMapper _mapper;
        public ChiNhanhService(IChiNhanhRepo cnRepo, IMapper mapper)
        {
            _cnRepo = cnRepo;
            _mapper = mapper;
        }
        public List<ChiNhanhDto> GetAll()
        {
            return _mapper.Map<List<ChiNhanhDto>>(_cnRepo.GetAll());
        }

        public ChiNhanhDto Get(Guid id)
        {
            return _mapper.Map<ChiNhanhDto>(_cnRepo.Get(id));
        }

        public bool Add(ChiNhanhDto cnDto)
        {
            return _cnRepo.Add(_mapper.Map<ChiNhanh>(cnDto));
        }

        public bool Update(ChiNhanhDto cnDto)
        {
            return _cnRepo.Update(_mapper.Map<ChiNhanh>(cnDto));
        }

        public bool Delete(Guid id)
        {
            return _cnRepo.Delete(id);
        }
    }
}
