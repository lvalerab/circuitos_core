using DomainLayer.Models;
using RepositoryLayer.Contratos;
using RepositoryLayer.Repository;
using ServiceLayer.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios
{
    public class UsuarioService : IUsuariosService
    {
        private ICrudRepository<UsuarioEntity, String> _repository;

        public UsuarioService(ICrudRepository<UsuarioEntity, String> repository)
        {
            _repository = repository;
        }

        public void ActualizaUsuario(UsuarioEntity usuarioEntity)
        {
            this._repository.Update(usuarioEntity);
        }

        public void BorraUsuario(String id)
        {
            this._repository.Remove(id);
        }

        public IEnumerable<UsuarioEntity> GetAllUsuarios()
        {
            return this._repository.GetAll();
        }

        public UsuarioEntity GetUsuario(string id)
        {
            return this._repository.Get(Id: id);
        }

        public void InsertaUsuario(UsuarioEntity usuarioEntity)
        {
            this._repository.Insert(usuarioEntity);
        }
    }
}
