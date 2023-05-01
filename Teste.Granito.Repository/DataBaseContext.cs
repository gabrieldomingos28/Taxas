using Microsoft.EntityFrameworkCore;
using Teste.Granito.Domain;

namespace Teste.Granito.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Taxa> Taxas { get; set; }
    }
}