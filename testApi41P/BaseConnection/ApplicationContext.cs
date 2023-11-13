using Microsoft.EntityFrameworkCore;
using testApi41P.ModelBase;

namespace testApi41P.BaseConnection
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constans.SqlConnection);
        }
    }
}
