using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MyTestDbContext : DbContext
    {
        public MyTestDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<emploess> Emploess { get; set; }
    }
}
