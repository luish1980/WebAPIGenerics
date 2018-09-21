using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebAPIGenerics.Service
{
    public class Services<T> : IService<T> where T:class
    {
        Context c = new Context();
        public List<T> ListAll()
        {
            List<T> x = c.Set<T>().AsQueryable().ToList();
            return x;
        }

        public List<T> ListWithPaging(int pageSize, int page)
        {
            int skip = (pageSize - 1) * page;
            int total = c.Set<T>().Count();

            //var records = from list in  select list;
            var userFilterPaging = c.Set<T>().AsEnumerable<T>()
                .Skip(skip)
                .Take(page)
                .ToList();

            return userFilterPaging;
        }

        public T findById(int id)
        {
            T t = c.Set<T>().Find(id);
            return t; 
        }

        public void save(T entity)
        {
            c.Set<T>().Add(entity);
            c.SaveChanges();
        }

        public void update(T entity)
        {
            c.Entry(entity).State = EntityState.Modified;
            c.SaveChanges();
        }

        public void delete(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }

        public int Count()
        {
            return c.Set<T>().Count();
        }

        
    }
}
