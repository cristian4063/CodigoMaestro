﻿using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;

namespace CodigoMaestro
{
    public class CodigoMaestroCoreModule : AbpModule
    {
        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
