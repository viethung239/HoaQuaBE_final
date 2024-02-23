using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Repositories
{
    public interface IRepo<T> where T : class, new()
    {
        List<T> GetAll(); //trả về 1 danh sách
        T? Get(Guid id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(Guid id);
    }
}
