using DomainLayer.EntityMapper;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new GrupoUsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuariosGruposUsuariosMap());
            modelBuilder.ApplyConfiguration(new UsuarioPasswordMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
