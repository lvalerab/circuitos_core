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
    public class SecureRepository<T, U, P> : ISecureRepository<T, U, P> where T : UsuarioEntity
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public string GetToken(T entidad)
        {
            if(entidad.EsMaquina)
            {
                return entidad.TokenMaquina;
            } else
            {
                //creamos el toquen
                return "";
            }
        }

        public IEnumerable<T> Validate(U usuario, P password)
        {
            if(entities!=null)
            {
                return entities.Where(u => u.Mail.Equals(usuario)).Select(p=>p);
            } else
            {
                return null;
            }
        }
    }
}
