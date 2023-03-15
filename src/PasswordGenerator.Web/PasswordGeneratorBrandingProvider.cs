using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PasswordGenerator.Web;

[Dependency(ReplaceServices = true)]
public class PasswordGeneratorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PasswordGenerator";
}
