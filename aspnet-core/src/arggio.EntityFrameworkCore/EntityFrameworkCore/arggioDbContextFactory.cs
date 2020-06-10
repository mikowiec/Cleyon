using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using arggio.Configuration;
using arggio.Web;

namespace arggio.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class arggioDbContextFactory : IDesignTimeDbContextFactory<arggioDbContext>
    {
        public arggioDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<arggioDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            arggioDbContextConfigurer.Configure(builder, configuration.GetConnectionString(arggioConsts.ConnectionStringName));

            return new arggioDbContext(builder.Options);
        }
    }
}
