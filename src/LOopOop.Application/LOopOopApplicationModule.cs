using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LOopOop.Authorization;

namespace LOopOop
{
    [DependsOn(
        typeof(LOopOopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LOopOopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LOopOopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LOopOopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
