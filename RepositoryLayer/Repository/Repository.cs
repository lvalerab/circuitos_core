using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T,PK> : ICrudRepository<T,PK> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public T Get(PK Id)
        {
            return entities.Where<T>(p => p.UID.Equals(Id)).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.Select(p => p).ToList();
        }

        public void Insert(T entity)
        {
            if(entities==null)
            {
                throw new Exception("BD000001 - La entidad no se ha especificado");
            } else
            {
                entities.Add(entity);
                _applicationDbContext.SaveChanges();
            }
        }

        public void Remove(PK id)
        {
            if (entities == null)
            {
                throw new Exception("BD000001 - La entidad no se ha especificado");
            }
            else
            {
                T entidad = this.Get(id);
                if(entidad!=null)
                    entities.Remove(entidad);
                _applicationDbContext.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new Exception("BD000001 - La entidad no se ha especificado");
            }
            else
            {
                entities.Update(entity);
                _applicationDbContext.SaveChanges();
            }
        }

    }
}
