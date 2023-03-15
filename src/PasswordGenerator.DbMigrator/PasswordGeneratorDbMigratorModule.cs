using PasswordGenerator.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PasswordGenerator.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PasswordGeneratorEntityFrameworkCoreModule),
    typeof(PasswordGeneratorApplicationContractsModule)
    )]
public class PasswordGeneratorDbMigratorModule : AbpModule
{

}
