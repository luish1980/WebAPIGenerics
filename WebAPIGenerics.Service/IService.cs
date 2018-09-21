using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIGenerics.Service
{
    public interface IService<T> where T:class
    {
        List<T> ListAll();
        T findById(int id);
        void findByEntity(T entity);
        void delete(int id);
        void save(T entity);

    }
}
