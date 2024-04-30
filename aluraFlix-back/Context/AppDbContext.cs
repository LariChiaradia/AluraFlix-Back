using aluraFlix_back.Models;
using Microsoft.EntityFrameworkCore;

namespace aluraFlix_back.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Videos>? Videos { get; set; }
    }
}
