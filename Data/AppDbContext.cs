using Microsoft.EntityFrameworkCore;
using StudentFormApp.Models;

namespace StudentFormApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } = default!;
    }
}