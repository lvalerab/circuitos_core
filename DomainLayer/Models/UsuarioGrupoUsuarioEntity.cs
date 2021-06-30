using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UsuarioGrupoUsuarioEntity
    {
        public string UidUsuario { get; set; }
        public string UidGrupoUsuario { get; set; }

        public UsuarioEntity Usuario { get; set; }
        public GrupoUsuariosEntity Grupo { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
