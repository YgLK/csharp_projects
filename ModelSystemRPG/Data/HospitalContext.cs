using Microsoft.EntityFrameworkCore;
using ModelSystemRPG.Data.Models;




namespace ModelSystemRPG.Data
{
    public class SystemPRGContext : DbContext
    {
        public SystemPRGContext()
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories{ get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=SystemRPG_db;Integrated Security=true");
            }
        }
    }
}
