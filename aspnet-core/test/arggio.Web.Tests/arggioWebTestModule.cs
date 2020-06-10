﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using arggio.EntityFrameworkCore;
using arggio.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace arggio.Web.Tests
{
    [DependsOn(
        typeof(arggioWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class arggioWebTestModule : AbpModule
    {
        public arggioWebTestModule(arggioEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(arggioWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(arggioWebMvcModule).Assembly);
        }
    }
}