using Microsoft.EntityFrameworkCore;
using az13ApiSeriesPersonajes.Models;

namespace az13ApiSeriesPersonajes.Data
{
    public class SeriesContext:DbContext
    {
        public SeriesContext(DbContextOptions options) : base(options){ }
        public DbSet<Serie> Series { get; set; }
    }
}
