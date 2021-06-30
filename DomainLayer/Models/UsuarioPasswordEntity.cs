using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UsuarioPasswordEntity:BaseEntity
    {
        public string Password { get; set; } 
        public bool IsActivated { get; set; }

        public UsuarioEntity Usuario { get; set; }
    }
}
