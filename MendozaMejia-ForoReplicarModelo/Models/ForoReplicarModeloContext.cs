using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendozaMejia_ForoReplicarModelo.Models
{
    public class ForoReplicarModeloContext : DbContext
    {
        public DbSet<NombreClase> NombreClases { get; set; }
        public DbSet<NombreClase2> NombreClase2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ForoDB_Modelo;Trusted_Connection=True;");
        }
    }
}
