using PasswordGenerator.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PasswordGenerator.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PasswordGeneratorController : AbpControllerBase
{
    protected PasswordGeneratorController()
    {
        LocalizationResource = typeof(PasswordGeneratorResource);
    }
}
