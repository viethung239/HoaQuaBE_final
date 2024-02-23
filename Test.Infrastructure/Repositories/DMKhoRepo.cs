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
    public class DMKhoRepo : Repo<DMKho>, IDMKhoRepo
    {
        public DMKhoRepo(TestDBContext dbContext) : base(dbContext) { }
    }
    
}
