using Microsoft.EntityFrameworkCore;
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
    public class Repo<T> : IRepo<T> where T : class, new()
    {
        private readonly TestDBContext _context;
        DbSet<T> _dbSet;

        //khởi tạo phương thức cho Repo
        public Repo(TestDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList(); //tập thực thể chuyển sang ToList
        }

        public T Get(Guid id)
        {
            return _dbSet.Find(id);
        }
        public bool Add(T entity)
        {
            bool flag = false;
            if (!_dbSet.Any(e => e == entity))
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }
            return flag;
        }

         public bool Update(T entity)
         {
             bool flag = true;
             if (!_dbSet.Any(e => e == entity))
             {
                 flag = false;
             }
             _context.Entry(entity).State = EntityState.Modified;
             try
             {
                 _context.SaveChanges();
             }
             catch (DbUpdateConcurrencyException)
             {
                 throw;
             }
             return flag;
         }
       



        public bool Delete(Guid id)
        {
            bool flag = true;
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                flag = false;
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return flag;

        }
    }
}
