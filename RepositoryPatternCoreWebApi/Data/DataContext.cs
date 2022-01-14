using Microsoft.EntityFrameworkCore;
using RepositoryPatternCoreWebApi.DBModals;

namespace RepositoryPatternCoreWebApi.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

    }
}
