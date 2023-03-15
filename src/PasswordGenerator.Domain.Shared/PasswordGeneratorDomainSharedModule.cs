using PasswordGenerator.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace PasswordGenerator;

[DependsOn(
    typeof(AbpAuditLoggingDomainSharedModule),
    typeof(AbpBackgroundJobsDomainSharedModule),
    typeof(AbpFeatureManagementDomainSharedModule),
    typeof(AbpIdentityDomainSharedModule),
    typeof(AbpOpenIddictDomainSharedModule),
    typeof(AbpPermissionManagementDomainSharedModule),
    typeof(AbpSettingManagementDomainSharedModule),
    typeof(AbpTenantManagementDomainSharedModule)    
    )]
public class PasswordGeneratorDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PasswordGeneratorGlobalFeatureConfigurator.Configure();
        PasswordGeneratorModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PasswordGeneratorDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<PasswordGeneratorResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/PasswordGenerator");

            options.DefaultResourceType = typeof(PasswordGeneratorResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("PasswordGenerator", typeof(PasswordGeneratorResource));
        });
    }
}
