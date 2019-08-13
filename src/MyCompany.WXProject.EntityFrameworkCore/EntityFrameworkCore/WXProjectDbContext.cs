using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompany.WXProject.Authorization.Roles;
using MyCompany.WXProject.Authorization.Users;
using MyCompany.WXProject.MultiTenancy;

namespace MyCompany.WXProject.EntityFrameworkCore
{
    public class WXProjectDbContext : AbpZeroDbContext<Tenant, Role, User, WXProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WXProjectDbContext(DbContextOptions<WXProjectDbContext> options)
            : base(options)
        {
        }
    }
}
