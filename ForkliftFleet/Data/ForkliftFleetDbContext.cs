using ForkliftFleet.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ForkliftFleet.Data
{
    public class ForkliftFleetDbContext : DbContext
    {
        public ForkliftFleetDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Forklift> Forklifts { get; set; }
    }
}
