using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LOopOop.EntityFrameworkCore
{
    public static class LOopOopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LOopOopDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LOopOopDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
