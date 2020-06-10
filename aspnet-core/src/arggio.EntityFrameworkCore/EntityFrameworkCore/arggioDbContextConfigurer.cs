using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace arggio.EntityFrameworkCore
{
    public static class arggioDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<arggioDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<arggioDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
