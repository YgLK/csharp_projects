using Microsoft.EntityFrameworkCore;
using ModelSystemRPG.Data.Models;




namespace ModelSystemRPG.Data
{
    public class SystemRPGContext : DbContext
    {
        public SystemRPGContext()
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<CategoryProperty> CategoryProperties { get; set; }
        public DbSet<ModelProperty> ModelProperties { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=SystemRPG_db;Integrated Security=true");
            }
        }
    }
}
