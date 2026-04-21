using Microsoft.EntityFrameworkCore;
using OrgAPI.Models;

namespace OrgAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
    }
}