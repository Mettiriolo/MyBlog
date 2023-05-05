using Microsoft.EntityFrameworkCore;

namespace MyBlog.Data
{
    public class AppDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SQLServerConnection"));
        }

        public DbSet<Post> Posts { get; set; }

    }
}
