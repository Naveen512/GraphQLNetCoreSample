using GraphQLSample.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSample.Data
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options) : base(options)
        {

        }

        public DbSet<Player> Player { get; set; }
    }
}
