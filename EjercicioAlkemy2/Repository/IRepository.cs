using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioAlkemy2.Repository
{
    public interface IRepository<T> where T:class
    {
        List<T> Get();
        void Add(T entity );
        void Update(T entity);
        void Delete(int id);
    }
}
