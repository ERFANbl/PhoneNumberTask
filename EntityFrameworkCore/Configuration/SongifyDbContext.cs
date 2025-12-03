using Domain.DbMpdels;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Configuration
{
    public class TaskDbContext : DbContext
    {
        public DbSet<UserPhoneNumber> UserPhoneNumbers { get; set; }


        private readonly IConfiguration _configuration;
        public TaskDbContext(DbContextOptions<TaskDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserPhoneNumber>()
                .HasKey(x => x.Id);
                
        }
    }
}
