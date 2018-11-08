using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Clases.ClasesModelo
{
    public partial class Usuarios
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        public string pnombre { get; set; }
        public string snombre { get; set; }
        public string apat { get; set; }
        public string amat { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<int> tipoUsuario { get; set; }
        public string email { get; set; }
    }
}
