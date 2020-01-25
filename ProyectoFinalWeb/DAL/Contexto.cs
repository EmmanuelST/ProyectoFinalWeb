using Microsoft.EntityFrameworkCore;
using ProyectoFinalWeb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoFinalWeb.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ./SqlExpress; Database= ProyectoFinalWebDb; Trusted_Connection = True; ");
        }
    }
}
