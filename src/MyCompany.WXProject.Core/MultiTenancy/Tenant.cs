using Abp.MultiTenancy;
using MyCompany.WXProject.Authorization.Users;

namespace MyCompany.WXProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
