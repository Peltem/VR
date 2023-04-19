namespace WebApplication3
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ApplicationContext> _logger;
        private string _connectionString = string.Empty;
        public DbSet<Brons> Bron { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=Bebra1;database=usersdb;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
