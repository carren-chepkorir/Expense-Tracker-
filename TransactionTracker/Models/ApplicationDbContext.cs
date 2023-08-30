using Microsoft.EntityFrameworkCore;

namespace TransactionTracker.Models
{
    public class ApplicationDbContext:DbContext//inherit froom base class(DbContext)
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

            
            
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet <Category>Categories { get; set; }
    }
}
