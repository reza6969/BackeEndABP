using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LOopOop.Configuration;

namespace LOopOop.Web.Host.Startup
{
    [DependsOn(
       typeof(LOopOopWebCoreModule))]
    public class LOopOopWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LOopOopWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LOopOopWebHostModule).GetAssembly());
        }
    }
}
