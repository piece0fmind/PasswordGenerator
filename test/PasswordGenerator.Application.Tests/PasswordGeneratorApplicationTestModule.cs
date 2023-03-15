using Volo.Abp.Modularity;

namespace PasswordGenerator;

[DependsOn(
    typeof(PasswordGeneratorApplicationModule),
    typeof(PasswordGeneratorDomainTestModule)
    )]
public class PasswordGeneratorApplicationTestModule : AbpModule
{

}
