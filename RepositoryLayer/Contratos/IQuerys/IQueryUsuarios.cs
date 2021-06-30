using RepositoryLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contratos.IQuerys
{
    public interface IQueryUsuarios
    {
        public List<UsuarioDTO> GetUsuarios();

        public UsuarioDTO GetUsuarioPorUID(string UID);

        public UsuarioDTO GetUsuarioPorTokenMaquina(string token);


    }
}
