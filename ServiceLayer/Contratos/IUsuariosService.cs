using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Contratos
{
    public interface IUsuariosService
    {
        IEnumerable<UsuarioEntity> GetAllUsuarios();

        UsuarioEntity GetUsuario(String id);

        void InsertaUsuario(UsuarioEntity usuarioEntity);

        void ActualizaUsuario(UsuarioEntity usuarioEntity);

        void BorraUsuario(String id);

        
    }
}
