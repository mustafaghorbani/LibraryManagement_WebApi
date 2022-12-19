
using LibraryManagement.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LibraryManagement.Infrastructure.DbContext
{
    /// <summary>
    /// Defines the <see cref="MsSqlDbContext" />.
    /// </summary>
    public class MsSqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly string connectionString;

        public MsSqlDbContext()
        {

        }
        public MsSqlDbContext(string connectionString)
        {
            this.connectionString=connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString: connectionString);
    }
}
