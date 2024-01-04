using Microsoft.EntityFrameworkCore;

namespace TestRainfallMeasurement.Models
{
    /// <summary>
    /// Rainfall Context
    /// </summary>
    public class RainfallContext : DbContext
    {
        /// <summary>
        /// RainfallContext constructor
        /// </summary>
        /// <param name="options"></param>
        public RainfallContext(DbContextOptions<RainfallContext> options) : base(options)
        {
        }

        /// <summary>
        /// RainModel DbSet
        /// </summary>
        public DbSet<RainModel> Rains { get; set; }

        /// <summary>
        /// RainItemModel DbSet
        /// </summary>
        public DbSet<RainItemModel> RainItems { get; set; }
    }
}
