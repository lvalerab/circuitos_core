using RepositoryLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contratos.ICommands
{
    public interface ICommandUsuarios
    {
        public void SaveUsuario(UsuarioDTO usuario);
        public void DeleteUsuario(String UID);
    }
}
