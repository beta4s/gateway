using Microsoft.EntityFrameworkCore;

namespace b4s.CommunicationOngoing.Data
{
    public class B4sDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public B4sDbContext(DbContextOptions<B4sDbContext> options): base(options)
        {
        }

        public DbSet<CommunicationOngoing.Models.CommunicationOngoing> CommunicationOngoings
        {
            get;
            set;
        }
    }

}
