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
            var x = c.Set<T>().AsQueryable().ToList();
            return x;
        }
        
        public Services()
        {
        }

        public void delete(int id)
        {
            
        }

        public void findByEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public T findById(int id)
        {

            throw new NotImplementedException();
        }

        public void save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
