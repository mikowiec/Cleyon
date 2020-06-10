using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using arggio.Authorization.Roles;
using arggio.Authorization.Users;
using arggio.MultiTenancy;

namespace arggio.EntityFrameworkCore
{
    public class arggioDbContext : AbpZeroDbContext<Tenant, Role, User, arggioDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public arggioDbContext(DbContextOptions<arggioDbContext> options)
            : base(options)
        {
        }
    }
}
