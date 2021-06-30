using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UsuarioEntity:BaseEntity
    {
        public String Nombre { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Mail { get; set; }
        public String Movil { get; set; }
        public Boolean EsMaquina { get; set; }
        public String TokenMaquina { get; set; }
        public String Login { get; set; }

        public IList<UsuarioGrupoUsuarioEntity> gruposUsuario { get; set; }
        public IList<UsuarioPasswordEntity> passwords { get; set; }
    }
}
