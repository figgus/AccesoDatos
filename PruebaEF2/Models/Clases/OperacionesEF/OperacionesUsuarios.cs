using PruebaEF2.Models.Clases.ClasesModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Clases.OperacionesEF
{
    public class OperacionesUsuarios
    {
        public ApplicationDbContext entities { get; set; }

        public OperacionesUsuarios()
        {
            entities = new ApplicationDbContext();
        }

        public List<Usuarios> TraerTodo()
        {
            List<Usuarios> listaRes = new List<Usuarios>();

            foreach (Usuarios users in entities.Usuarios)
            {
                listaRes.Add(users);
            }
            return listaRes;
        }
    }
}
