using Microsoft.EntityFrameworkCore;

namespace asp.net_web_api
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        /*public ApplicationContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = database.db");
        }*/

        public DbSet<Category> Categories { get; set; }
        public DbSet<Todoitem> Todolist { get; set; }
    }
}
