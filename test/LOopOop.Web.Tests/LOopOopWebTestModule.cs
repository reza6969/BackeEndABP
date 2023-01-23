using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LOopOop.EntityFrameworkCore;
using LOopOop.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LOopOop.Web.Tests
{
    [DependsOn(
        typeof(LOopOopWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LOopOopWebTestModule : AbpModule
    {
        public LOopOopWebTestModule(LOopOopEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LOopOopWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LOopOopWebMvcModule).Assembly);
        }
    }
}