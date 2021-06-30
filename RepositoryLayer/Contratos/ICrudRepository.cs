using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contratos
{
    public interface ICrudRepository<T,PK>
    {
        IEnumerable<T> GetAll();

        T Get(PK Id);

        void Insert(T entity);
        void Update(T entity);
        void Remove(PK id);
        void SaveChanges();
    }
}
