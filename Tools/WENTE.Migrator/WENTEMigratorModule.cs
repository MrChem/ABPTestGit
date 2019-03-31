using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using WENTE.EntityFramework;

namespace WENTE.Migrator
{
    [DependsOn(typeof(WENTEDataModule))]
    public class WENTEMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<WENTEDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}