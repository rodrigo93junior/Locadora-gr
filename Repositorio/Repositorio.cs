using System.Collections.Generic;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class Context : DbContext 
    {
        public DbSet<Cliente> Clientes {get; set; }
        public DbSet<VeiculoPesado> VeiculosPesados {get; set; }
        public DbSet<VeiculoLeve> VeiculosLeves {get; set; }
        public DbSet<Locacao> Locacoes {get; set; }
        public DbSet<LocacaoVeiculoPesado> LocacaoVeiculosPesados {get; set; }
        public DbSet<LocacaoVeiculoLeve> LocacaoVeiculosLeves {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySql("Server=localhost;User Id=root;Database=locadora");

    }
}