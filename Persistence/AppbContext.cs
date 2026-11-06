using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class AppbContext (DbContextOptions options) : DbContext(options)
    {
        public DbSet<Activity> Activities { get; set; }
        
    }
}