using PasswordGenerator.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PasswordGenerator;

[DependsOn(
    typeof(PasswordGeneratorEntityFrameworkCoreTestModule)
    )]
public class PasswordGeneratorDomainTestModule : AbpModule
{

}
