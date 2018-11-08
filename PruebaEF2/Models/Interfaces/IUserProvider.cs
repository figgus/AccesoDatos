using PruebaEF2.Models.Clases.ClasesModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Interfaces
{
    public interface IUserProvider
    {
        IEnumerable<Usuarios> GetUsuarios();

    }
}
