using Microsoft.EntityFrameworkCore;

namespace controle.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Produit> produits { get; set; }


        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}
