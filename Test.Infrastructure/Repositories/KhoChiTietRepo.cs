using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Entities;
using Test.Domain.Repositories;
using Test.Infrastructure.Context;

namespace Test.Infrastructure.Repositories
{
    public class KhoChiTietRepo : Repo<KhoChiTiet>, IKhoChiTietRepo
    {
        public KhoChiTietRepo(TestDBContext dbContext) : base(dbContext) { }
    }
 
}
