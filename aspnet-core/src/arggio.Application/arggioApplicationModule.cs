using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using arggio.Authorization;

namespace arggio
{
    [DependsOn(
        typeof(arggioCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class arggioApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<arggioAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(arggioApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
