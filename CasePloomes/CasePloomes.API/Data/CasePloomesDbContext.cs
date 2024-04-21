using CasePloomes.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CasePloomes.API.Data
{
    public class CasePloomesDbContext : DbContext
    {
        public CasePloomesDbContext(DbContextOptions<CasePloomesDbContext> options) : base(options)
        {
        }

        public DbSet<ClientesEntity> Clientes { get; set; }
        public DbSet<ProdutosEntity> Produtos { get; set; }
        public DbSet<VendasEntity> Vendas { get; set; }
    }
}
