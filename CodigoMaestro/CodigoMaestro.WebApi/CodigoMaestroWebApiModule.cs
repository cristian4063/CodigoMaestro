using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Application;
using Abp.WebApi.Startup;

namespace CodigoMaestro
{
    public class CodigoMaestroWebApiModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpApplicationModule),
                       typeof(AbpWebApiModule),
                       typeof(CodigoMaestroApplicationModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
