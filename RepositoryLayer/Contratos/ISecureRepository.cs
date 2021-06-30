using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contratos
{
    interface ISecureRepository<T,U,P>
    {
        IEnumerable<T> Validate(U usuario, P password);

        String GetToken(T entidad);

    }
}
