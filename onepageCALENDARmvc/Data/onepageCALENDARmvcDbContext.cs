using Microsoft.EntityFrameworkCore;
using onepageCALENDARmvc.Models;

namespace onepageCALENDARmvc.Data
{
    public class onepageCALENDARmvcDbContext : DbContext
    {
        public onepageCALENDARmvcDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CalendarEntry> CalendarEntrys { get; set; }
    }
}
