using imo.api.Models;
using Microsoft.EntityFrameworkCore;

namespace imo.api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> option) : base(option) {}

        //public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}