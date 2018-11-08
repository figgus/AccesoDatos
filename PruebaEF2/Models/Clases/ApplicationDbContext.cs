using Microsoft.EntityFrameworkCore;
using PruebaEF2.Models.Clases.ClasesModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF2.Models.Clases
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-E6EV4RF\\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
