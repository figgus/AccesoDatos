using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Clases
{
    public class UsuariosMongo
    {
        public UsuariosMongo()
        {

        }

        public List<Usuario> TraerTodo()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("datos");
            var coll = db.GetCollection<Usuario>("datos");
            return coll.Find(_ => true).ToListAsync<Usuario>().Result;
        }

        public List<Usuario> TraerPorNombre(string nom)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("datos");
            var coll = db.GetCollection<Usuario>("datos");
            return coll.Find(p => p.nombre == nom).ToListAsync<Usuario>().Result;
        }

        public bool BorrarRegistro(string nom)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("datos");
            var coll = db.GetCollection<Usuario>("datos");
            coll.DeleteOne(p => p.nombre == nom);
            return true;
        }

        public async Task<bool> ActualizarRegistro(string nom, Usuario newUser)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("datos");
            var coll = db.GetCollection<Usuario>("datos");
            DbType myObject; // passed in 
            var filter = Builders<Usuario>.Filter.Eq(s => s.nombre, newUser.nombre);
            var result = await coll.ReplaceOneAsync(filter, myObject);
            return true;
        }
    }
}
