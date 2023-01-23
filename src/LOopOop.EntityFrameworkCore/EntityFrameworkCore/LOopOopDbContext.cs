using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LOopOop.Authorization.Roles;
using LOopOop.Authorization.Users;
using LOopOop.MultiTenancy;

namespace LOopOop.EntityFrameworkCore
{
    public class LOopOopDbContext : AbpZeroDbContext<Tenant, Role, User, LOopOopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LOopOopDbContext(DbContextOptions<LOopOopDbContext> options)
            : base(options)
        {
        }
    }
}
