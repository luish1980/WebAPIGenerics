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
        void delete(T t);
        void save(T entity);
        List<T> ListWithPaging(int pageSize, int page);

    }
}
