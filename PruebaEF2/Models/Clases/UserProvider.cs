using Dapper;
using PruebaEF2.Models.Clases.ClasesModelo;
using PruebaEF2.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Clases
{
    public class UserProvider : IUserProvider
    {
        public readonly string connectionString;

        public UserProvider()
        {
            this.connectionString = "Server=DESKTOP-E6EV4RF\\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        public IEnumerable<Usuarios> GetUsuarios()
        {
            IEnumerable<Usuarios> usuario;
            using (var connection=new SqlConnection(this.connectionString))
            {
                usuario = connection.Query<Usuarios>("select * from Usuarios");
                
            }
            
            return usuario;
        }

        public bool ExisteUsuario(string username,string password)
        {
            IEnumerable<Usuarios> usuario;
            using (var connection = new SqlConnection(this.connectionString))
            {
                string sql = string.Format("select * from Usuarios where nombreUsuario='{0}' and password='{1}'",username,password);
                usuario = connection.Query<Usuarios>(sql);
                if (usuario.Count<Usuarios>()>0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
